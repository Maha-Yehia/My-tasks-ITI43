#include <iostream>

using namespace std;

void Merge(int arr[] , int lf , int ll , int rf , int rl )
{
        int *tempArr = new int [sizeof arr] ;
          int savelf = lf ;
        int index = lf ;

        while ((lf<=ll)&&(rf<=rl))
        {
            if (arr[lf]<arr[rf])
                tempArr[index++] = arr[lf++];
            else
                   tempArr[index++] = arr[rf++];
        }

        while(lf<=ll)
        {
            tempArr[index++] = arr[lf++] ;
        }

         while(rf<=rl)
        {
            tempArr[index++] = arr[rf++] ;
        }

        for(int i=savelf ; i<=rl;i++)
        {
            arr[i] =tempArr[i] ;
        }
}


void mergeSort (int arr[] , int first , int last)
{
    if(first<last) /// divide
    {
        int mid = (first +last)/2 ;
        mergeSort(arr  , first , mid) ;/// left
         mergeSort(arr ,mid+1 , last) ;/// left
         Merge(arr , first,mid , mid+1 , last  ) ;
    }
}


int main()
{

 int arr[10] = {18,5,9,20,41,2,7,34,6,20};
 int arr2[7] = {1,3,5,2,6,3,7};

mergeSort(arr  ,0,9) ;
 for(int i=0 ; i<10 ; i++)
 {
     cout<<arr[i]<<" " ;
 }
cout<<endl ;

mergeSort(arr2 , 0 , 6) ;
 for(int i=0 ; i<7 ; i++)
 {
     cout<<arr2[i]<<" " ;
 }
cout<<endl ;

    return 0;
}
