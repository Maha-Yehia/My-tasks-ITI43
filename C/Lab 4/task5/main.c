#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#define Enter 13

int main()
{

    char name[15] , ch ;

    //enter the name
    for (int i=0; i<15 ;i++)
    {
        ch = _getche() ;
if (ch == 13)
{
    name[i] = '\0';
    break;
}
name[i] = ch ;
    }

    printf("\n");
//output the name

for(int i = 0; i<15;i++)
{
    printf("%c",name[i]);
if (name[i]=='\0')
    break ;
}

}



