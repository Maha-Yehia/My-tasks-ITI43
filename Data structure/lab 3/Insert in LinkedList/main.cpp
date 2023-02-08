#include <iostream>

using namespace std;

class Node
{
public:
    int Data;
    Node* pNext;
    Node* pPrev;
};

Node* pStart;
Node* pLast;


Node* NewNode(int Data)
{
    Node* pNew = new Node();
    if (pNew == NULL) exit(0);
    pNew -> Data = Data;
    pNew->pPrev = pNew->pNext = NULL;
    return pNew;
}

void InsertNode (int Data)
{
    Node* pNew = NewNode(Data);
    if (pStart==NULL)
        pStart=pLast=pNew;
    else
    {
        Node* pSearch = pStart;
        while ((pSearch!=NULL)&&(pSearch->Data<Data))
            pSearch=pSearch->pNext;
        if (pSearch==NULL)
        {
            pLast->pNext=pNew;
            pNew->pPrev=pLast;
            pLast=pNew;
        }
        else if (pSearch==pStart)
        {
            pStart->pPrev=pNew;
            pNew->pNext=pStart;
            pStart=pNew;
        }
        else
        {
            pNew->pNext=pSearch;
            pSearch->pPrev->pNext=pNew;
            pNew->pPrev=pSearch->pPrev;
            pNew->pNext->pPrev=pNew;
        }
    }
}

void DisplayAll ()
{
    Node* PDisplay=pStart;

    while (PDisplay!=NULL)
    {
        cout<<PDisplay->Data<<endl;
        PDisplay=PDisplay->pNext;
    }
}

int main()
{
    InsertNode(2);
    InsertNode(4);
    InsertNode(10);
    InsertNode(5);
    InsertNode(11);
    InsertNode(3);
    InsertNode(6);
    DisplayAll();
}
