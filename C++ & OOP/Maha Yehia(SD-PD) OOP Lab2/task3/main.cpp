#include <iostream>

using namespace std;


class myQueue
{
    int head ; // for removing
    int tail  ; // for adding
    int length ; // check the queue full or empty
    int *que ;
    int s ;

    public :

        myQueue (int l)
        {
            s = l ;
            head = 0 ;
            tail = s-1 ;
            que = new int [s] ;
            length = 0 ;
            cout<<"constructor"<<endl ;
        }

        ~myQueue ()
        {
            cout<<"destructor"<<endl ;
             delete [] que ;
        }

   bool isFull () {return length == s ; }
   bool isEmpty () {return length == 0 ; }


   // input & output
   void enQueue (int n )
{
    if (!isFull())
    {
         tail = (tail+1) % s ; ///
    que[tail] = n ;
    length ++ ;
    return  ;
    }
   // else cout<<"the queue is full"<<endl ;

}

    int deQueue ()
{
    if (!isEmpty())
    {
       ///head = (head+1) %s ;
    return que[head++] ;
    length--  ;
    }

    else cout<<"the queue is empty"<<endl ;
}

int peek ()
{
    if(!isEmpty())
   return que[head] ;
   else  cout<<"the queue is empty"<<endl ;
 }


 int getCount()
{
   if (!isEmpty())
    {
    int n = que[tail]  ;
return n ;
 }
   else cout<<"the stack is empty"<<endl ;
}

/*void printQueue ()
{
    if(!isEmpty())
    {


    for (int i = head ; i !=tail ; i=(i+1)%s)
    {
        cout<<que[i] ;

    }
cout << que[tail] ;

 }
else  cout<<"the queue is empty"<<endl ;
}*/


};








int main()
{
myQueue q1(100);

q1.enQueue(10) ;
q1.enQueue(20) ;
q1.enQueue(30) ;
q1.enQueue(40) ;

 cout<<q1.deQueue()<<endl ;
  cout<<q1.deQueue()<<endl ;

    q1.enQueue(50) ;
    q1.enQueue(60) ;

cout<<q1.peek()<<endl ;
cout<<q1.peek()<<endl ;
cout<<q1.peek()<<endl ;
cout<<q1.deQueue()<<endl ;

}
