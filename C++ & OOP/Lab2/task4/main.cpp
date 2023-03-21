#include <iostream>

using namespace std;

// shiffting
class myQueue
{
    int tail;
    int s;
    int *que;
    int head;
    int length ;

   public:
        myQueue(int l){
            s = l;
            tail = 0;
           head= 0;
           length = 0 ;
            que = new int[s];
cout<<"constructor"<<endl ;

            }

        ~myQueue(){
            delete [] que;
            cout<<"destructor"<<endl ;
        }


bool isFull () {return length == s ; }
   bool isEmpty () {return length == 0 ; }

        void enQueue (int n){

            if(!isFull()){
                que[tail++] = n;
               length++ ;
                if(tail == s){
                    tail = 0;
                }

            }
            else{
                cout <<"Queue is Full" <<endl;
            }
        }

        int deQueue(){

            if(!isEmpty()){
                q = que[tail++] ;
              length-- ;

            }
            else{
                cout <<"Queue is Empty " <<endl;
                return -1;
            }
        }
};



int main()
{

    myQueue q1(10) ;

   q1.enQueue(1) ;
   q1.enQueue(2) ;
   q1.enQueue(3) ;
   q1.enQueue(4) ;


    cout << q1.deQueue() <<endl ;

    cout << q1.deQueue() <<endl ;


 q1.enQueue(5) ;


    return 0;
}
