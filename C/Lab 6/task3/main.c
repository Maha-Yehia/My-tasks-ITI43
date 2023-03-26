#include <stdio.h>
#include <stdlib.h>


int main()
{
    int size ;
    printf("Please enter the size of array ") ;
    scanf("%i" ,&size) ;
    int Arr[size] ;
    int *ptr ;
    ptr = &Arr[0] ;
    for (int i=0 ; i<size ; i++)
    {
        printf("Please enter value#%i " , i+1) ;
        scanf("%i",&ptr[i]) ;
    }

  for (int i=0 ; i<size ; i++)
    {
        printf("%i " ,*ptr) ;
        ptr++ ;
    }

}
