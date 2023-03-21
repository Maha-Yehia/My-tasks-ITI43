
class MyStack
{
        int tos , s ;
        int *stk = new int [s] ;

    public :


    // constructor
    MyStack (int l)
    {
        cout<<"constructor"<<endl ;
        s = l ;
        tos = 0 ;
       stk = new int [s] ;
    }

    // destructor
~MyStack ()
    {
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

};




int main()
{
    MyStack s1(5) ;

    s1.push(1) ;
    s1.push(2) ;
    s1.push(3) ;
    s1.push(4) ;
    s1.push(5) ;

    cout<<s1.pop()<<endl ;
 cout<<s1.pop()<<endl ;
  cout<<"the current number of elements in the stack = "  ;
cout<<s1.getCount()<<endl ;
 cout<<s1.peek()<<endl ;
  cout<<s1.peek()<<endl ;
 cout<<s1.pop()<<endl ;
}
