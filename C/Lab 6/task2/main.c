#include <stdio.h>
#include <stdlib.h>

// swap by address
    void swap (int *x , int *y)
    {
    int temp = *x ;
    *x = *y ;
    *y = temp ;
    }

int main()
{
   int a , b ;
   printf("Please enter the first number A ") ;
   scanf("%i" ,& a) ;

   printf("Please enter the second number B ") ;
   scanf("%i" ,& b) ;

   swap(&a,&b) ;

printf("A=%i \n",a) ;
printf("B=%i \n",b) ;

}
