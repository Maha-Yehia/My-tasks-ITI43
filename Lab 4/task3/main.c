#include <stdio.h>
#include <stdlib.h>
#include <conio.h>


int main()
{

    char firstName[15] , lastName[15] ;

    printf("please enter your first name ");

    gets(firstName);

    printf("please enter your last name ");

    gets(lastName);

strcat(firstName," ");
strcat(firstName,lastName) ;

printf("your name is ") ;

puts (firstName) ;


}
