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

    int i,r,c,n ;
  printf("please enter n value");
     scanf("%i",&n);

    r=1 , c=(n/2+1) ;

    for(i=1;i<=n*n;i++)
    {
gotoxy(c*4,r*3);
printf("%i\n",i);
printf("\n");

if(i%n==0){
    r++;
if(r==(n+1))
r=1;
}
else
{
    r--;
    c--;
if(r==0)
        r=n;
if(c==0)
        c=n;


}

}

}
