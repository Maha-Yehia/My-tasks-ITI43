#include <iostream>

using namespace std;

 void PrintQueue(int que[] , int Size){
    for(int i=Size-1 ; i>=0 ; i-- ){
        cout << "i" << " = " << que[i] << "\n\n";

    }
}

class ShiffingQueue
{
    int tail;
    int Size;
    /// not know size of array => will allocate arr in heap
    int *que;
    int Length;

   public:
        /// Constractor
        ShiffingQueue(int _Size){
            Size = _Size;
            tail = 0;
            Length = 0;
            que = new int[Size];

             /// Initialize queue
            for(int i=0 ; i<Size ; i++){
                que[i] = 0;
            }
        }

        ///Destractor
        ~ShiffingQueue(){
            delete [] que;
        }

        /// check if stack full
        int isFull(){return (Length == Size) ;}
        int isEmpty(){return (Length == 0) ;}


        void ENQ(int num){
            /// check is not full
            if(!isFull()){
                /// push first then increase
                que[tail] = num;
                tail++;
                Length++;
                if(tail == Size){
                    tail = 0;
                }
                cout << "====== Push " << num << "=======\n ";
                PrintQueue(que ,Size);
            }
            else{
                cout <<"Queue is Full \n";
            }
        }

        /// POP
        int DEQ(){
            int deq ;
            /// check is not full
            if(!isEmpty()){
                deq = que[tail];
                que[tail] = que[tail+1];
                Length--;
                cout << "====== PoP ======= \n" ;
                return deq;
            }
            else{
                cout <<"Queue is Empty \n";
                return -1;
            }
        }
};



int main()
{
    int Size;
    cout << "Enter Size of Queue array \n" << endl;
    cin >> Size;

    /// Same Output when using Circular Queue
    ShiffingQueue q(4);

    q.ENQ(5);
    q.ENQ(2);
    q.ENQ(1);
    q.ENQ(4);
    q.ENQ(8);

    cout << "POP = " << q.DEQ() << endl;
    q.ENQ(6);
    cout << "POP = " << q.DEQ() << endl;

    q.ENQ(7);
    q.ENQ(8);




    return 0;
}
