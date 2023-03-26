#include <iostream>

using namespace std;

template <class myType>
class MyStack
{
        int tos , s ;
        myType *stk = new myType [s] ;

    public :
    // constructor
    MyStack (int l=5)
    {
        cout<<"constructor"<<endl ;
        s = l ;
        tos = 0 ;
       stk = new myType [s] ;

    }

    // destructor

~MyStack ()
    {

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

void push (myType n )
{
    if (!isFull())
    stk[tos++] = n ;
    else cout<<"the stack is full"<<endl ;
}

    myType pop ()
{
    if (!isEmpty())
    return stk[--tos] ;
    else cout<<"the stack is empty"<<endl ;
}

// return the last element
myType peek ()
{
    if (!isEmpty())
    {
    myType n = stk[tos-1]  ;
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
    stk = new myType [s] ;
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



MyStack<int> s3,s4,s5;
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


MyStack<string> s6,s7,s8;

s6.push("maha");
s6.push("yehia");
s6.push("ahmed");

s6.viewContent();

 s7=s6 ;
cout<<"********"<<endl ;
s7.viewContent();
cout<<"********"<<endl ;
s8=s6+s7 ;
cout<<"********"<<endl ;
s8.viewContent();
    return 0;
}
