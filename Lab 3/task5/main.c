#include <stdio.h>
#include <stdlib.h>

int main()
{


// enter matrix 1


int x[3][2];

//enter the array value

for(int i=0 ;i<3 ;i++)
{
   for(int j=0 ;j<2 ;j++)
    {
    printf("for matrix 1 enter a new number");
    scanf("%d",&x[i][j]);
   }
}


int y[2][1];

//enter the array value

for(int i=0 ;i<2 ;i++)
{
   for(int j=0 ;j<1 ;j++)
    {
    printf("for matrix 2 enter a new number");
    scanf("%d",&y[i][j]);
   }
}

int z[3][1];

// multiple

for (int i=0;i<3;i++)
{
    for (int j=0;j<1;j++)
    {
        int sum = 0  ;
        for (int k=0;k<2;k++)
      sum = sum + ((x[i][k]) * (y[k][j])) ;
      z[i][j]=sum;
     printf("%d\n",sum);
      }

}


}
