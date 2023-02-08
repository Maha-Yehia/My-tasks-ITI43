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

//get sum of each row

int sum;
for(int i=0 ;i<r ;i++)
{
    sum = 0 ;
   for(int j=0 ;j<c ;j++)
    {
    sum +=x[i][j];
   }

   printf("the sum of row %d is %d\n",i+1,sum);

}



}

