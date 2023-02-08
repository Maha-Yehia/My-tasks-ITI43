#include <iostream>

using namespace std;

int binarySeachRecursive (int arr[],int value , int low , int high)
{
    if(low<=high)
    {
   int mid = (low+high)/2 ;
   if (value==arr[mid]) return mid ;

   else if (value<arr[mid]) /// go left
    binarySeachRecursive(arr , value , low , mid-1) ;

   else
    binarySeachRecursive(arr , value , mid+1 , high) ;
    }

return -1 ;
}



int main()
{

int arr[10] = {1,2,3,4,5,6,7,8,9,10} ;

cout<<binarySeachRecursive(arr , 5,0,9) <<endl ;
cout<<binarySeachRecursive(arr , 11,0,9) <<endl ;

    return 0;
}
