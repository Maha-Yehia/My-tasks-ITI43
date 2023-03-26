#include <iostream>

using namespace std;


//Array

template <class myType>

class myArray {

myType *arr ; /// object attribute
int Size  ; /// object attribute
static int counter ; /// class attribute


public :

//Constructor
 myArray (int l=5)
{
    Size = l ;
    arr = new myType[Size] ;



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
     myType *arr ;
     int Size ;
      Size = oldr.Size ;
      arr = new myType[Size] ;
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
    arr = new myType [Size] ;
    for (int i =0 ; i<Size ; i++)
    arr[i] = r.arr[i] ;
    return *this  ;
}

void setValue(int index , myType value)
 {
if (index>=0&& index<Size)
    arr[index] = value ;
}

myType getValue (int index)
{
    if (index>=0 && index<Size)
    return arr[index] ;
}

static int getCounter ()
{
    return counter ;
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

template <class myType>
int myArray< myType>::counter = 0 ;



int main()
{
myArray<int> a1(9) , a2 ;
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
myArray<int> a3 , a4 , a5;
a4[0]=5; a4[1]=4;//a2.viewContent() ;
a5[0]=5; a5[1]=4;

a3 = a4+a5 ;
a3.viewContent() ;

cout<<"********"<<endl ;
myArray<string>a6 (10) ;
a6.setValue(0,"maha");
a6.setValue(1,"ahmed");
a6.setValue(2,"huda");
a6.viewContent() ;

cout<<myArray<int>::getCounter()<<endl ;

    return 0;
}
