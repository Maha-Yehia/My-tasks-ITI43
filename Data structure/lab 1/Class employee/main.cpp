#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <string.h>
#include <conio.h>
#include <iostream>

#define NormalPen 0x0F
#define HighLightPen 0X1A
#define Enter 0x0D
#define ESC 27
#define Size 10
#define options 6

using namespace std;



class Employee
{
    int ID;
    int age;
    string Name;
public:
    int getID()
    {
        return ID;
    }
    int getAge()
    {
        return Age;
    }
    string getName()
    {
        return Name;
    }

    void setID(int _id)
    {
        ID = _id;
    }
    void setName(string _name)
    {
        Name = _name;
    }
    void setAge(int _age)
    {
        Age = _age;
    }
};

class Node
{

    Node *next;
    Node *prev;
    Employee data;
    Node *startptr;
    Node *lastptr;
public:
    Node()
    {
        startptr = lastptr = NULL;
    }
    void add_node();
    void display_all();
    Node* search_by_id(int id);
    void display();
    void delete_all();
    void delete_by_id();
    Node * new_node(Employee e);
};


Node* Node::new_node(Employee e)
{
    Node *n = new Node();
    n->data = e;
    n->next = NULL;
    n->prev = NULL;
    return n;
}

/// Global Vars


void gotoxy( int column, int line )
{
    COORD coord;
    coord.X = column;
    coord.Y = line;
    SetConsoleCursorPosition(
        GetStdHandle( STD_OUTPUT_HANDLE ),
        coord
    );
}

void textattr(int i)
{
    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);
}



int main()
{
    char menu[options][20] = {"Add Node","Display All","Display by ID","Delete All","Delete Node","Exit"};
    int i, current = 0, ExitFlag = 0;
    char ch;
    Node n;

    do
    {
        textattr(NormalPen);
        system("cls");

        for(i = 0 ; i<options; i++)
        {
            if(current == i)
                textattr(HighLightPen);
            else textattr(NormalPen);

            gotoxy(50,5+(3*i));
            printf("%s",menu[i]);
        }

        ch = _getch();

        switch (ch)
        {
        case Enter:
            switch (current)
            {
            case 0:///add new node
                n.add_node();
                break;
            case 1:///display all
                n.display_all();
                break;
            case 2:///display all
                n.display();
                break;
            case 3:///delete all
                n.delete_all();
                break;
            case 4:///delete node by id
                n.delete_by_id();
                break;
            case 5:///exit
                ExitFlag = 1;
                break;
            }
            break;
        case ESC:
            ExitFlag = 1;
            break;
        case -32:
            ch = _getch();
            switch (ch)
            {
            case 72:///up
                current--;
                if(current<0) current = options-1;
                break;
            case 80:///down
                current++;
                if(current>options-1) current = 0;
                break;
            case 71:///home
                current = 0;
                break;
            case 79:
                current = 5;
                break;
            }
        }
    }
    while(!ExitFlag==1);
    return 0;
}

void Node::add_node()
{
    system("cls");
    Employee e;
    int id, age;
    string name;
    gotoxy(50,0);
    printf("Employee Data");

    ///OutPuts
    gotoxy(5,5);
    printf("ID:");

    gotoxy(5,10);
    printf("Name:");

    gotoxy(5,15);
    printf("Age:");

    ///Inputs
    gotoxy(15,5);
    cin>>id;
    e.setID(id);

    gotoxy(15,10);
    cin>>name;
    e.setName(name);

    gotoxy(15,15);
    cin>>age;
    e.setAge(age);

    Node *newNode = new_node(e);

    if(startptr == NULL)
    {
        startptr = lastptr = newNode;
    }
    else
    {
        lastptr->next = newNode;
        newNode->prev = lastptr;
        lastptr = newNode;
    }

}
void Node::display_all()
{
    system("cls");
    Node *temp = startptr;
    while(temp!= NULL)
    {
        cout<<"ID: "<< temp->data.getID() <<"|Name: "<< temp->data.getName() <<"|Age: "<<temp->data.getAge()<< endl;
        temp = temp->next;
    }
    getch();
}
Node* Node::search_by_id(int id)
{
    Node *temp = startptr;
    while(temp!= NULL)
    {
        if(temp->data.getID() == id)
        {
            break;
        }
        temp = temp->next;
    }
    return temp;
}

void Node::display()
{
    system("cls");
    int id;
    cout<<"Please Enter Employee ID To Display: "<<endl;
    cin>>id;

    Node *temp = search_by_id(id);
    if(temp == NULL)
    {
        cout<<"User Not Found!"<<endl;
    }
    else
    {
        cout<<"ID: "<< temp->data.getID() <<"|Name: "<< temp->data.getName() <<"|Age: "<<temp->data.getAge()<< endl;
    }
    getch();
}
void Node::delete_all()
{
    system("cls");
    while(startptr->next != NULL)
    {
        startptr = startptr->next;
        delete startptr->prev;
    }
    delete startptr;
    startptr = lastptr = NULL;
    cout<<"All users deleted successfully"<<endl;
    getch();

}

void Node::delete_by_id()
{
    system("cls");
    int id;
    cout<<"Please Enter Employee ID To Delete: "<<endl;
    cin>>id;

    Node *temp = search_by_id(id);

    if(temp == NULL)
    {
        cout<<"User Not Found!"<<endl;
    }
    else if(startptr == lastptr)
    {
        startptr = lastptr = NULL;
    }
    else if(temp == startptr)
    {
        startptr = startptr->next;
        startptr->prev = NULL;
        delete temp;
    }
    else if (temp == lastptr)
    {
        lastptr = lastptr->prev;
        lastptr->next = NULL;
        delete temp;
    }
    else
    {
        temp->prev->next = temp->next;
        temp->next->prev = temp->prev;
        delete temp;
    }

    getch();

}


