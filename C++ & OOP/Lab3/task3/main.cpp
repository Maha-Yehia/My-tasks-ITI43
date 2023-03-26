#include <iostream>

using namespace std;


///view Content
class MyStack
{
        int tos , s ;
        int *stk = new int [s] ;

    public :
    // constructor
    MyStack (int l=10)
    {
        cout<<"constructor"<<endl ;
        s = l ;
        tos = 0 ;
       stk = new int [s] ;
    }

    // destructor

~MyStack ()
    {
  /*for (int i =0  ; i<tos ; i++)
   {
    stk[i] = -1 ;
     }*/
      cout<<"destructor"<<endl;
  delete [] stk ;
    }

    bool isFull () {return tos == s ; }
    bool isEmpty () {return tos == 0 ; }

void push (int n )
{
    if (!isFull())
    stk[tos++] = n ;
    else cout<<"the stack is full"<<endl ;
}

    int pop ()
{
   if (!isEmpty())
    return stk[--tos] ;
    else cout<<"the stack is empty"<<endl ;
    return -1 ;
}

// return the last element
int peek ()
{
    if (!isEmpty())
    {
    int n = stk[tos-1]  ;
cout<<"the peek number is "  ;
return n ;
 }
   else cout<<"the stack is empty"<<endl ;

}

// number of elements in the stack
int getCount()
{
    return tos ;
}

///with copy constructor

MyStack (MyStack & olds)
{
    tos  = olds.tos ;
    s = olds.s ;
    stk = new int [s] ;

   for (int i = 0 ; i<tos ; i++)
        stk[i] = olds.stk[i] ;
}


friend void viewContent(MyStack s) ;


///Reverse function

MyStack Reverse ()
{
    MyStack res ;
    for (int i = 0 ; i<tos ; i++)
        {
         res.stk[i] = stk[(tos-i-1)] ;
         res.tos++;
    }
    return res ;
}

};

 void viewContent(MyStack s)
{
 for (int i=0 ; i<s.tos ; i++)
    cout<<s.stk[i]<<endl ;
}


int main()
{
    MyStack s1(10) ;

    s1.push(1) ;
    s1.push(2) ;
    s1.push(3) ;
    s1.push(4) ;
    s1.push(5) ;
    s1.push(6) ;

   /* cout<<s1.pop()<<endl ;
 cout<<s1.pop()<<endl ;
  cout<<"the current number of elements in the stack = "  ;
cout<<s1.getCount()<<endl ;
 cout<<s1.peek()<<endl ;
  cout<<s1.peek()<<endl ;
 cout<<s1.pop()<<endl ;*/

viewContent(s1) ;
/*cout<<s1.Reverse().pop()<<endl ;
cout<<s1.Reverse().pop()<<endl ;
cout<<s1.Reverse().pop()<<endl ;*/
//cout<<s1.pop()<<endl ;
cout<<" ******* " <<endl ;
MyStack s2 ;

s2=s1.Reverse() ;
cout<<" ******* " <<endl ;
viewContent(s2) ;

cout<<" ******* " <<endl ;
cout<<s1.Reverse().pop()<<endl ;
cout<<s1.Reverse().pop()<<endl ;

return 0 ;
}
