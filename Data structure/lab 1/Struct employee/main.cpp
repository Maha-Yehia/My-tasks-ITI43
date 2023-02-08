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
#define options 7

using namespace std;



typedef struct Employee
{
    int ID;
    int Age;
    char Name[10];
} Employee;

typedef struct Node
{
    Node *next;
    Node *prev;
    Employee data;
} Node;

Node* new_node(Employee e)
{
    Node *n = new Node();
    n->data = e;
    n->next = NULL;
    n->prev = NULL;
    return n;
}

/// Global Vars
Node *startptr;
Node *lastptr;

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


void add_node();
void display_all();
void search_by_id();
void display();
void delete_all();
void delete_by_id();
int main()
{
    char menu[options][20] = {"Add Node","Display All","Search","Display by ID","Delete All","Delete Node","Exit"};
    int i, current = 0, ExitFlag = 0;
    char ch;

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
                add_node();
                break;
            case 1:///display all
                display_all();
                break;
            case 2:///search by id
                search_by_id();
                break;
            case 3:///display all
                display();
                break;
            case 4:///delete all
                delete_all();
                break;
            case 5:///delete node by id
                delete_by_id();
                break;
            case 6:///exit
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
                current = 6;
                break;
            }
        }
    }
    while(!ExitFlag==1);
    return 0;
}

void add_node()
{
    system("cls");
    Employee e;
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
    cin>>e.ID;

    gotoxy(15,10);
    cin>>e.Name;

    gotoxy(15,15);
    cin>>e.Age;

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
void display_all()
{
    system("cls");
    Node *temp = startptr;
    while(temp!= NULL)
    {
        cout<<"ID: "<< temp->data.ID <<"|Name: "<< temp->data.Name <<"|Age: "<<temp->data.Age<< endl;
        temp = temp->next;
    }
    getch();
}
void search_by_id()
{
    system("cls");
    int id;
    cout<<"Please Enter Employee ID To Search: "<<endl;
    cin>>id;

    Node *temp = startptr;
    int found = 0;
    while(temp!= NULL)
    {
        if(temp->data.ID == id)
        {
            cout<<"ID: "<< temp->data.ID <<"|Name: "<< temp->data.Name <<"|Age: "<<temp->data.Age<< endl;
            found =1;
            break;
        }
        temp = temp->next;
    }
    if(!found)
    {
        cout<<"User Not Found!"<<endl;
    }
    getch();
}

void display()
{
    system("cls");
    int id;
    cout<<"Please Enter Employee ID To Display: "<<endl;
    cin>>id;

    Node *temp = startptr;
    int found = 0;
    while(temp!= NULL)
    {
        if(temp->data.ID == id)
        {
            cout<<"ID: "<< temp->data.ID <<"|Name: "<< temp->data.Name <<"|Age: "<<temp->data.Age<< endl;
            found =1;
            break;
        }
        temp = temp->next;
    }
    if(!found)
    {
        cout<<"User Not Found!"<<endl;
    }
    getch();
}
void delete_all()
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

void delete_by_id()
{
    system("cls");
    int id;
    cout<<"Please Enter Employee ID To Delete: "<<endl;
    cin>>id;

    Node *temp = startptr;
    int found = 0;
    while(temp!= NULL)
    {
        if(temp->data.ID == id)
        {
            cout<<"ID: "<< temp->data.ID <<"|Name: "<< temp->data.Name <<"|Age: "<<temp->data.Age <<" Deleted Successfully!"<< endl;
            if(temp == startptr)
            {
                startptr = startptr->next;
                startptr->prev = NULL;
                delete temp;
            }else if (temp == lastptr)
            {
                lastptr = lastptr->prev;
                lastptr->next = NULL;
                delete temp;
            }else
            {
                temp->prev->next = temp->next;
                temp->next->prev = temp->prev;
                delete temp;
            }
            found =1;
            break;
        }
        temp = temp->next;
    }
    if(!found)
    {
        cout<<"User Not Found!"<<endl;
    }
    getch();


}

