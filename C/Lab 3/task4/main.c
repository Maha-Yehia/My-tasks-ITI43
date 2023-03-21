#include <stdio.h>
#include <stdlib.h>

int main()
{
    int r,c;

printf("please enter the number of rows");
scanf("%d",&r);

printf("please enter the number of columns");
scanf("%d",&c);


int x[r][c];

//enter the array value

for(int i=0 ;i<r ;i++)
{
   for(int j=0 ;j<c ;j++)
    {
    printf("enter a new number");
    scanf("%d",&x[i][j]);
   }

}

//get avg of each col

int avg ;
for(int i=0 ;i<c ;i++)
{
    avg= 0 ;
   for(int j=0 ;j<r ;j++)
    {
    avg +=x[j][i];
   }

avg = avg/r ;

   printf("the avg of cols %d is %d\n",i+1,avg);
}



}

