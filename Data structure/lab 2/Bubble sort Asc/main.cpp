#include <iostream>

using namespace std;

void Swap (int &x, int &y)
{
    int temp = x ;
    x = y ;
    y=temp ;

}


void bubbleSort(int arr[] , int Size)
{
    bool sorted ;
    for (int i=0 ; i<Size ; i++)
    {
        sorted = true ;
        for (int j=0 ; j<Size-i-1 ; j++)
        {
            if (arr[j]>arr[j+1])
            {
                Swap (arr[j+1] , arr[j]) ;
                sorted = false ;
            }
        }
        if(sorted) return ;
    }
}



int main()
{

 int arr[10] = {18,5,9,20,41,2,7,34,6,20};
 int arr2[7] = {1,3,5,2,6,3,7};

bubbleSort(arr , 10) ;
 for(int i=0 ; i<10 ; i++)
 {
     cout<<arr[i]<<" " ;
 }
cout<<endl ;

bubbleSort(arr2 , 7) ;
 for(int i=0 ; i<7 ; i++)
 {
     cout<<arr2[i]<<" " ;
 }
cout<<endl ;

    return 0;
}
