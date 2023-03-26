#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include <windows.h>
#define NormalPen 0x0F // black back ground & white font
#define HighLightPen 0XF0 //white back ground & black font
#define Enter 0x0D
#define Esc 27

void gotoxy( int column, int line )
  {
  COORD coord;
  coord.X = column;
  coord.Y = line;
  SetConsoleCursorPosition(GetStdHandle( STD_OUTPUT_HANDLE ),coord);
  }
  void textattr (int i)
{
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);
}

struct employee

{
    int ID , age ;
    char name[100] , address[200] , gender[6] ;
    double salary , overTime, deduct , netSalary ;

};


int main()
{

struct employee e ;

printf("Please enter the below information \n");


   gotoxy(5 , 2+(0*3));
   printf("ID: \n");



   gotoxy(5 , 2+(1*3));
printf("Name: \n");
gotoxy(5 , 2+(2*3));
printf("Age: \n");
gotoxy(5 , 2+(3*3));
printf("Gender: \n");
gotoxy(40 , 2+(0*3));
printf("Address: \n");
gotoxy(40 , 2+(1*3));
printf("Salary: \n");
gotoxy(40 , 2+(2*3));
printf("Over Time: \n");
gotoxy(40 , 2+(3*3));
printf("Deduct Value: \n");



 gotoxy(13 , 2+(0*3));
scanf("%i",&e.ID) ;
gotoxy(13 , 2+(1*3));
scanf("%s",&e.name);
gotoxy(13 , 2+(2*3));
scanf("%i",&e.age);
gotoxy(13 , 2+(3*3));
scanf("%s",&e.gender);
gotoxy(54 , 2+(0*3));
scanf("%s",&e.address);
gotoxy(54 , 2+(1*3));
scanf("%lf",&e.salary);
gotoxy(54 , 2+(2*3));
scanf("%lf",&e.overTime);
gotoxy(54 , 2+(3*3));
scanf("%lf",&e.deduct);


e.netSalary = e.salary + e.overTime - e.deduct ;

printf("\n");
printf("Employee Name : %s \n" ,e.name);

printf("Employee ID : %i \n",e.ID);

printf("Net Salary : %lf \n",e.netSalary);



/*char menu [3][5] = {"New" , "Save" , "Exit"} ;
int current =0 , exitFlag = 0 ;

do
{

 textattr(NormalPen);
system ("cls") ; // clear screen

for (int i=0;i<3;i++)
{
if (current == i )
 textattr(HighLightPen) ;
 else
    textattr(NormalPen);

  gotoxy(10 , 5+(i*3));

    printf("%s\n\n\n",menu[i]);
}

char ch = _getch();

switch (ch)
{
   case Enter:
       switch(current)
       {
       case 0: //new
           system("cls") ;
           printf ("enter new date");
           _getch();

        break ;

         case 1: //save
              system("cls") ;
             printf ("Data have been saved");
             _getch();
        break ;

         case 2: // exit
             exitFlag = 1 ;
        break ;
       }



    break ;

    case Esc:

        exitFlag = 1 ;
    break ;

    case -32 : // extended key
        ch = _getch(); // get second byte from user for the extended keys
        switch (ch)
        {
            case 72 : // case up ascci
                current-- ;
                if (current < 0)
                    current = 2 ;

            break;

             case 80 : // case down ascci

                 current++ ;
                if (current > 2)
                    current = 0 ;
            break;

             case 71 : // case home ascci
                 current = 0 ;
            break;

             case 79: // case end ascci
                  current = 2 ;
            break;
        }

  }

} while (exitFlag == 0) ;
*/
}

