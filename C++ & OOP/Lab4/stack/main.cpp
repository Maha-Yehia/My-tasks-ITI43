#include <iostream>

using namespace std;

class MyStack
{
        int tos , s ;
        int *stk = new int [s] ;

    public :
    // constructor
    MyStack (int l=5)
    {
        cout<<"constructor"<<endl ;
        s = l ;
        tos = 0 ;
       stk = new int [s] ;

        /// to initialize array = 0
    for (int i=0; i<tos; i++)
        stk[i] = 0;
    }

    // destructor

~MyStack ()
    {
   for (int i =0  ; i<tos ; i++)
   {
    stk[i] = -1 ;
     }
      cout<<"destructor"<<endl;
  delete [] stk ;
    }

    //setter & getter for  size
void setSize (int n)
{
    s = n ;
}

int getSize()
{
    return s ;
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
   for (int i = 0 ; i<tos ; i++)
        stk[i] = olds.stk[i] ;
}

void viewContent()
{
 for (int i=0 ; i<tos ; i++)
    cout<<stk[i]<<endl ;
}


MyStack & operator = (const MyStack & r)
{
    delete [] stk ;
    tos = r.tos ;
    s= r.s ;
    stk = new int [s] ;
    for (int i =0 ; i<tos ; i++)
    stk[i] = r.stk[i] ;
    return *this  ;
}

/// Append two stacks in one stack
    /*MyStack operator +(MyStack &s1){
        int Size_ = s1.s + s;
        MyStack R(Size_);

        for(int i=0 ; i<tos ; i++){
            R.push(stk[i]);
        }
        for(int i=0 ; i<s1.tos ; i++){
            R.push(s1.stk[i]);
        }

    return R;
    }*/

/// sum for stacks
     MyStack operator +(MyStack &s1){

        MyStack R(s);

        for(int i=0 ; i<tos ; i++){
            R.push(stk[i]+s1.stk[i]);
        }
    return R;
    }




int & operator [] (int index)
{
    if (index>=0 && index<s)
    return stk[index] ;
}


};



int main()
{

   /* MyStack s1(10) ;
    s1.push(1);
    s1.push(2);
    s1.push(3);
    s1.push(4);
    s1.push(5);
    s1.viewContent() ;

    cout<<"********"<<endl ;

    MyStack s2(10) ;
   s2=s1 ;
 s2.viewContent() ;

   cout<<"********"<<endl ;*/



MyStack s3,s4,s5;
    s4.push(1);
    s4.push(2);
    s4.push(3);
    s4.push(4);

   s4.viewContent();
    cout<<"********"<<endl ;
    s5.push(1);
    s5.push(2);
    s5.push(3);
    s5.push(4);


s5.viewContent();
cout<<"********"<<endl ;

s3 = s4+s5 ;
s3.viewContent();



    return 0;
}
