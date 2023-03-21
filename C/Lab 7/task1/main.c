#include <stdio.h>
#include <stdlib.h>

int main()
{

int  stdN , subN , *sum , *avg ; ///
int **Marks ;


printf("Enter students number ") ;
scanf("%i" ,&stdN) ;

printf("Enter subjects number ") ;
scanf("%i" ,&subN) ;

Marks = (int **) malloc (stdN * sizeof(int*)) ;
sum = (int *) malloc (stdN * sizeof(int)); ///
avg = (int *) malloc (subN * sizeof(int)); ///
for(int i=0 ; i<stdN ; i++)
{
    Marks[i] = (int *) malloc (subN * sizeof(int)) ;
}

for (int i=0 ; i<stdN ; i++) {sum[i] = 0 ;}
for (int i=0 ; i<subN ; i++){avg[i] = 0 ;}
for (int i=0 ; i<stdN ; i++)
{
    for (int j=0 ; j<subN ; j++)
    {
printf ("Subject %i , student %i " , j+1 , i+1 );
scanf("%i" ,& Marks[i][j]);
sum[i]+=Marks[i][j] ;
avg[j]+=Marks[i][j] ;
    }
 }


 for (int i=0 ; i<stdN ; i++)
{
printf("sum of student number %i = %i \n" ,i+1 , sum[i]) ;

}


for (int i=0 ; i<subN ; i++)
{
avg[i]/=stdN ;
printf("avg of student number %i = %i \n" ,i+1 ,avg[i]) ;
}


for (int i = 0 ; i<stdN ; i++)
    {
free (Marks[i]) ;
}
free (Marks) ;
free (sum) ;
free (avg) ;

}
