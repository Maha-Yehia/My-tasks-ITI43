#include <stdio.h>
#include <stdlib.h>

int main()
{

 int x,sum ;

 sum = 0;


do{
    printf("inter a new number");
     scanf("%i",&x);
    sum = sum+x ;
} while(sum<=100);

printf("%i",sum-x);

}





