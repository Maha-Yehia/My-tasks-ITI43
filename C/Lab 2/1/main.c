#include <stdio.h>
#include <stdlib.h>
#include <windows.h>

int main()
{

    void gotoxy( int column, int line )
  {
  COORD coord;
  coord.X = column;
  coord.Y = line;
  SetConsoleCursorPosition(
    GetStdHandle( STD_OUTPUT_HANDLE ),
    coord
    );
  }

    int i,r,c ;
    r=1 , c=2 ;

    for(i=1;i<=9;i++)
    {
gotoxy(c*4,r*3);
printf("%i\n",i);
printf("\n");

if(i%3==0){
    r++;
if(r==4)
r=1;
}
else
{
    r--;
    c--;
if(r==0)
        r=3;
if(c==0)
        c=3;


}

}

}




