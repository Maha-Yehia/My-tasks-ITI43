#include <iostream>

using namespace std;

int binarySeachIterative (int arr[],int value , int Size)
{
    int low = 0 , high = Size-1 ;
    while (low<=high)
    {
        int mid = (low+high)/2 ;
        if(value == arr[mid]) return mid ;
        if (value<arr[mid]) /// go left
            high = mid-1;
         if (value>arr[mid]) /// right
            low = mid+1 ;
    }

return -1 ;
{
}
}


int main()
{

int arr[10] = {1,2,3,4,5,6,7,8,9,10} ;

cout<<binarySeachIterative(arr , 5,10) <<endl ;
cout<<binarySeachIterative(arr , 11,10) <<endl ;

    return 0;
}
