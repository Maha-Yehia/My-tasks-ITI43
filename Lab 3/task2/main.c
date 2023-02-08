#include <stdio.h>
#include <stdlib.h>

int main()
{
    int size;

printf("please enter the size of array");
scanf("%d",&size);
int x[size];

//enter the array vakue

for(int i=0 ;i<size ;i++)
{
    printf("enter a new number");
    scanf("%d",&x[i]);
}


// get max values

 int max = x[0];
for(int i=0 ;i<size ;i++)
{
if (x[i]>max)

max=x[i];

}
printf("max value is %d\n",max);

// get min values

 int min = x[0];
for(int i=0 ;i<size ;i++)
{
if (x[i]<min)

min=x[i];

}
printf("min value is %d",min);



}
