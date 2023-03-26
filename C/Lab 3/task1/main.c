#include <stdio.h>
#include <stdlib.h>

int main()
{
int size;

printf("please enter the size of array");
scanf("%d",&size);
int x[size];
for(int i=0 ;i<size ;i++)
{
    printf("enter a new number");
    scanf("%d",&x[i]);
}

for(int j=0 ; j<size;j++)

    printf("%d",x[j]);

}
