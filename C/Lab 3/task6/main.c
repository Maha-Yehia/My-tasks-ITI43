#include <stdio.h>
#include <stdlib.h>

int main()
{

 int r,c;

printf("please enter the number of rows for matrix 1\n");
scanf("%d",&r);

printf("please enter the number of columns for matrix 1\n");
scanf("%d",&c);


// enter matrix 1


int x[r][c];

//enter the array value

for(int i=0 ;i<r ;i++)
{
   for(int j=0 ;j<c ;j++)
    {
    printf("for matrix 1 enter a new number\n");
    scanf("%d",&x[i][j]);
   }
}

int b;

printf("please enter the number of columns for matrix 2\n");
scanf("%d",&b);


int y[c][b];

//enter the array value

for(int i=0 ;i<c ;i++)
{
   for(int j=0 ;j<b ;j++)
    {
    printf("for matrix 2 enter a new number");
    scanf("%d",&y[i][j]);
   }
}

int z[r][b];

// multiple

for (int i=0;i<r;i++)
{
    for (int j=0;j<b;j++)
    {
        int sum = 0  ;
        for (int k=0;k<c;k++)
      sum = sum + ((x[i][k]) * (y[k][j])) ;
      z[i][j]=sum;
     printf("%d\n",sum);
      }

}

}
