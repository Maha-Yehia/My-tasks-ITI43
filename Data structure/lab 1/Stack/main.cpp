#include <iostream>

using namespace std;

struct Employee
{
    int id;
    int age;
    string name;
};

struct Node
{
    Employee data;
    Node *next;
    Node *prev;
};

Node* new_node(Employee e)
{
    Node *n = new Node();
    n->data = e;
    n->next = NULL;
    n->prev = NULL;
    return n;
}

class MyStack
{
    int Size;
    Node *top, *last;
public:
    MyStack()
    {
        Size = 0;
        top = last = NULL;
    }

    bool isEmpty()
    {
        return top == NULL;
    }

    Employee pop()
    {
        Employee temp;
        if(!isEmpty())
        {
            temp = last->data;
            if(last->prev != NULL)
            {
                last = last->prev;
                delete last->next;
                last->next = NULL;
            }
            else
            {
                delete last;
                last = top = NULL;
            }
           Size--;

            return temp;
        }
        cout<<"Stack is Empty"<<endl;
        return temp;
    }

    void push(Employee e)
    {
        Node *newNode = new_node(e);
        if(top == NULL)
        {
            top = last = newNode;
        }
        else
        {
            last->next = newNode;
            newNode->prev = last;
            last = newNode;
        }
        Size++;

    }

    Employee peek()
    {
        if(isEmpty()) cout<<"Empty List"<<endl;
        else return last->data;
    }

    int numberOfElements()
    {
        return Size;
    }

    ~MyStack()
    {
    }
};

int main()
{

    Employee e;
    Employee e1;

    e.id = 1;
    e.age = 24;
    e.name = "maha";

    e1.id = 2;
    e1.age = 25;
    e1.name = "yehia";



    MyStack s;
    s.push(e);
    s.push(e1);
    cout<<s.pop().name<<endl;
    cout<<s.pop().name<<endl;
    cout<<s.peek().name<<endl;



    return 0;
}



