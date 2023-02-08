#include <iostream>

using namespace std;

void Swap (int &x, int &y)
{
    int temp = x ;
    x = y ;
    y=temp ;

}


void selectionSort (int arr[] , int Size )
{
    for (int i=0 ; i<Size ; i++)
    {
        int minIndex = i;
        for (int j=i+1; j<Size;j++)
        {
          if (arr[j]<arr[minIndex])
            minIndex = j ;
        }
 Swap (arr[minIndex] , arr[i]) ;
    }

}




int main()
{

 int arr[10] = {18,5,9,20,41,2,7,34,6,20};


selectionSort(arr , 10) ;
 for(int i=0 ; i<10 ; i++)
 {
     cout<<arr[i]<<" " ;
 }
cout<<endl ;


    return 0;
}
