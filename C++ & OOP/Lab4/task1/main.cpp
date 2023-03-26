#include <iostream>

using namespace std;


//Array
class myArray {

int *arr , Size  ;
int counter = 0 ;


public :

//Constructor
 myArray (int l=5)
{
    Size = l ;
    arr = new int[Size] ;

    /// to initialize array = 0
    for (int i=0; i<Size; i++)
        arr[i] = 0;

    counter++ ;
    cout<<"constructor"<<endl ;
}

//destructor
~myArray ()
{
      cout<<"destructor"<<endl ;
    delete []arr ;

}

//copy constructor

myArray (const myArray & oldr)
{
     int *arr ;
     int Size ;
      Size = oldr.Size ;
      arr = new int[Size] ;
    for (int i=0; i<Size; i++)
    arr[i] = oldr.arr[i] ;
}

//setter & getter for  size
void setSize (int s)
{
    Size = s ;
}

int getSize()
{
    return Size ;
}



void viewContent()
{
 for (int i=0 ; i<Size ; i++)
    cout<<arr[i]<<endl ;
}

// = operator

myArray & operator = (const myArray & r)
{
    delete [] arr ;
    //tos = r.tos ;
    Size = r.Size ;
    arr = new int [Size] ;
    for (int i =0 ; i<Size ; i++)
    arr[i] = r.arr[i] ;
    return *this  ;
}

void setValue(int index , int value)
 {
if (index>=0&& index<Size)
    arr[index] = value ;
}

int getValue (int index)
{
    if (index>=0 && index<Size)
    return arr[index] ;
}




int & operator [] (int index)
{
    if (index>=0 && index<Size)
    return arr[index] ;
}

/*int operator int ()
{
    return real ;
}*/


    myArray operator + ( myArray & a1 )
    {
        myArray r(Size) ;

        for (int i =0 ; i< Size; i++)
            {
                r.arr[i] = a1.arr[i] + arr[i] ;
            }
            return r ;
    }
};





int main()
{
myArray a1(9) , a2 ;
a1.setValue(0,5);
a1.setValue(1,2);
a1.setValue(2,3);



a1.viewContent() ;

//cout<<a1[1]<<endl ;
//a1.setSize(7) ;
//cout<<a1.getSize()<<endl ;

cout<<"********"<<endl ;

a2=a1;

a2.viewContent() ;
//cout<<a2[0]<<endl ;

cout<<"********"<<endl ;
myArray a3 , a4 , a5;
a4[0]=5; a4[1]=4;//a2.viewContent() ;
a5[0]=5; a5[1]=4;

a3 = a4+a5 ;
a3.viewContent() ;


    return 0;
}
