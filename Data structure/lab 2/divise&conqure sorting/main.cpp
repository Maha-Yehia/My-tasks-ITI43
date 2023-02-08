#include <iostream>

using namespace std;
///Quick sort

void Swap (int &x, int &y)
{
    int temp = x ;
    x = y ;
    y=temp ;

}

int Partition(int arr[], int start, int last)
{

    int temp = arr[start];

    int counter = 0;
    for (int i = start + 1; i <= last; i++) {
        if (arr[i] <= temp)
            counter++;
    }


    int Index = start + counter;
    Swap(arr[Index], arr[start]);


    int i = start, j = last;

    while (i < Index && j > Index) {

        while (arr[i] <= temp) {
            i++;
        }

        while (arr[j] > temp) {
            j--;
        }

        if (i < Index && j > Index) {
            Swap(arr[i++], arr[j--]);
        }
    }

    return Index;
}

void quickSort(int arr[], int start, int last)
{


    if (start >= last)
        return;


    int p = Partition(arr, start, last);

  ///left part
    quickSort(arr, start, p - 1);
 /// right part
    quickSort(arr, p + 1, last);
}

int main()
{
 int arr[10] = {18,5,9,20,41,2,7,34,6,20};


quickSort(arr , 0,9) ;
 for(int i=0 ; i<10 ; i++)
 {
     cout<<arr[i]<<" " ;
 }
cout<<endl ;

 int arr2[7] = {1,3,5,2,6,3,7};
quickSort(arr2 , 0 , 6) ;
 for(int i=0 ; i<7 ; i++)
 {
     cout<<arr2[i]<<" " ;
 }
cout<<endl ;

    return 0;
}



