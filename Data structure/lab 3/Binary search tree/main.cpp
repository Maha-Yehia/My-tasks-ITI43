#include <iostream>
#include<stdlib.h>

using namespace std;

struct Node
{
    int data ;
    Node *pleft ;
    Node *pright ;
    int Count = 0 ;
};

Node *ptree = NULL ;


string searchTree (Node *proot , int key  )
{
    while(proot!=NULL)
    {
    if (key == proot->data )
        return "found" ;
    else if (key<proot->data) /// go left
        proot = proot->pleft;

        else   /// go right
        proot = proot->pright;
    }
    return "not found" ;
}

int countNodes (Node* proot)
{
 if (proot!=NULL)
 {
     return countNodes(proot->pleft) +1 + countNodes(proot->pright) ;
 }
return 0 ;
}
///if printing asc
void treeTraverseAsc (Node* proot)
{
     if (proot!=NULL)
     {
        /// visit left
        cout<<proot->data<<endl ;
        treeTraverseAsc(proot->pleft) ;


        /// visit right
       treeTraverseAsc(proot->pright);

        }

}

///if printing des
void treeTraverseDes (Node* proot)
{
     if (proot!=NULL)
     {
           /// visit right
        treeTraverseDes(proot->pright);
         cout<<proot->data<<endl ;

        /// visit left
        treeTraverseDes(proot->pleft);

        }
}

Node* newNode ()
{
    Node* pnew = new Node() ;

  ///  if (pnew==NULL) (exit (0)) ;

    pnew->pleft = NULL ;
    pnew->pright = NULL ;

    cout<<"Please enter a new key"<<endl ;
    cin>>pnew->data ;
    return pnew ;
}





int MAX (int x, int y)
{
    if (x>y)
        return x;
    else if (y>x)
        return y;
    else
        return x;
}

int Height(Node* pRoot)
{
   int H = 0;
   if (pRoot != NULL)
    {
      int l_height = Height(pRoot->pleft);
      int r_height = Height(pRoot->pright);
      int max_height = MAX(l_height, r_height);
      H = max_height + 1;
    }
   return H;
}

int Difference(Node* pRoot)
{
   int l_height = Height(pRoot->pleft);
   int r_height = Height(pRoot->pright);
   int BF = l_height - r_height;
   return BF;
}

Node* RR_Rotat(Node* Pparent)
{
   Node* Child;
   Child = Pparent->pright;
   Pparent->pright = Child->pleft;
   Child->pleft = Pparent;
   cout<<"Right-Right Rotation\n";
   return Child;
}

Node* LL_Rotat(Node* Pparent)
{
   Node* Child;
   Child = Pparent->pleft;
   Pparent->pleft = Child->pright;
   Child->pright = Pparent;
   cout<<"Left-Left Rotation\n";
   return Child;
}

Node* LR_Rotat(Node* Pparent)
{
   Node* Child;
   Child = Pparent->pleft;
   Pparent->pleft = RR_Rotat(Child);
   cout<<"Left-Right Rotation\n";
   return LL_Rotat(Pparent);
}

Node* RL_Rotat(Node* Pparent)
{
   Node* Child;
   Child = Pparent->pright;
   Pparent->pright = LL_Rotat(Child);
   cout<<"Right-Left Rotation\n";
   return RR_Rotat(Pparent);
}

Node* Balance(Node* pRoot)
{
   int BF = Difference(pRoot);
   if (BF > 1)
   {
      if (Difference(pRoot->pleft) > 0)
         pRoot = LL_Rotat(pRoot);
      else
         pRoot = LR_Rotat(pRoot);
   }
   else if (BF < -1)
   {
      if (Difference(pRoot->pright) > 0)
         pRoot = RL_Rotat(pRoot);
      else
         pRoot = RR_Rotat(pRoot);
   }
   return pRoot;
}


int GetMax (Node* pMax)
{
    while (pMax->pright != NULL)
        pMax=pMax->pright;
    return pMax->data;
}

/// using reference
Node* insertNode (Node* &proot , Node *pnew )
{
    if (proot == NULL)
    proot = pnew ;

     else if (pnew<proot) /// insert left
        insertNode(proot->pleft , pnew ) ;

        else   /// insert right
    insertNode(proot->pright , pnew ) ;
}


/// two pointers
Node* insertNode2 (Node* &pRoot, Node* pNew)
{
    if (pRoot==NULL)
    {
        pRoot=pNew;
        return pRoot;
    }

    else if (pNew->data > pRoot->data)
    {
        pRoot->pright=insertNode2 (pRoot->pright,pNew);
        pRoot=Balance(pRoot);
    }

    else if (pNew->data < pRoot->data)
    {
        pRoot->pleft=insertNode2 (pRoot->pleft,pNew);
        pRoot=Balance(pRoot);
    }


    else
        cout << "Duplicate is not Allowed\n";
    return pRoot;
}




void Delete (Node* &proot , int key) ;
void DeleteNode(Node* &proot)
{
    Node* pdelete = proot;

    ///leaf or node with single child
    if(proot->pleft == NULL)
    {
        proot=proot->pright ;
        delete pdelete ;
    }

    else if (proot->pright==NULL)
    {
        proot=proot->pleft ;
        delete pdelete ;
    }
    ///root(has two child)
    else
    {
      int tempKey = GetMax(proot->pleft) ; ///get max in left sub tree
      proot->data = tempKey ;
      Delete(proot->pleft ,tempKey ) ;
 }

}


void Delete (Node* &proot , int key)
{
    if (key<proot->data)
        Delete(proot->pleft , key ) ;
        else if (key>proot->data)
        Delete(proot->pright , key ) ;
        else
       DeleteNode(proot) ;

}




int main()
{

for(int i=0;i<5;i++)
   insertNode(ptree , newNode()) ;
    cout<<endl ;
    treeTraverseAsc(ptree) ;
       cout<<endl ;
treeTraverseDes(ptree) ;
   cout<<endl ;
  cout<<"number of nodes = " <<countNodes(ptree)<<endl ;

  cout<<searchTree(ptree , 5)<<endl  ;
 cout<<searchTree(ptree , 8)<<endl  ;

 Delete(ptree , 3) ;
 treeTraverseAsc(ptree) ;
       cout<<endl ;


    return 0;
}
