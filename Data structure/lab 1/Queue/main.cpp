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

class MyQueue
{
    int Size;
    Node *top, *last;
public:
    Queue()
    {
        Size = 0;
        top = last = NULL;
    }

    bool isEmpty()
    {
        if (top == NULL)
            return true;
        return false;
    }

    void enqueue(Employee e)
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

    Employee dequeue()
    {
        Employee temp;
        if(!isEmpty())
        {
            temp = top->data;
            if(top->next != NULL)
            {
                top = top->next;
                delete top->prev;
                top->prev = NULL;
            }
            else
            {
                delete top;
                last = top = NULL;
            }
            Size--;

            return temp;
        }
        cout<<"Empty Queue"<<endl;
        return temp;
    }

    Employee peek()
    {
        Employee e;
        if (!isEmpty())
        {
            e = top->data;
            return e;
        }
        else
        {
            cout << " Empty Queue" << endl;
            return e;
        }
    }

    int ElementsNum()
    {
        return Size;
    }


};

int main()
{
    MyQueue q;
 Employee e;
    Employee e1;

    e.id = 1;
    e.age = 24;
    e.name = "maha";

    e1.id = 2;
    e1.age = 25;
    e1.name = "yehia";


    q.enqueue(e);
    q.enqueue(e1);

    cout<<"Number of elements: "<<q.ElementsNum()<<endl;
    cout<<q.peek().name<<endl;
    cout<<q.dequeue().name<<endl;

    return 0;
}
