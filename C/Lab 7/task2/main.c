#include <stdio.h>
#include <stdlib.h>
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
    double salary , overTime, deduct  ;

} ;
struct employee eArr[10] ;


void getEmployee (int ID2)
{
for (int i=0;i<10;i++){
if (ID2==eArr[i].ID)
    {
printf ("below information for employee %i" , i);
printf("\n");
printf("Employee Name : %s \n"  , eArr[i].name);
printf("Employee ID : %i \n",eArr[i].ID);
printf("Employee Net Salary : %lf \n",eArr[i].salary+eArr[i].overTime-eArr[i].deduct);
printf("\n") ;
return ;
}
}
printf ("No data found !");
}


void deleteByID(int ID2)
{
    for(int i=0;i<10;i++)
        {
        if(eArr[i].ID==ID2){
            eArr[i].ID="";
            eArr[i].name[100]= ' ' ;
            eArr[i].salary=0;
            eArr[i].overTime=0;
            eArr[i].deduct=0;
            printf("Employee with ID %d has been removed \n",ID2);
            return;
    }
    }
     printf("ID not found\n");

}


void deleteByName(char name2[100])
{
    for(int i=0;i<10;i++)
        {
        if(strcmp (eArr[i].name,name2)==0 ){
            eArr[i].name[100]= ' ' ;
            eArr[i].ID="";
            eArr[i].salary=0;
            eArr[i].overTime=0;
            eArr[i].deduct=0;

            printf("Employee with Name %s has been removed \n",name2);
            return;
    }
    }
     printf("Name not found\n");

}

int main()
{

char menu [6][30] = {"New" , "Display by ID", "Display All","Delete by ID","Delete by Name","Exit"} ;
 int current =0 , exitFlag = 0 ;
int i , index = 0 , ID2=0 ;
char name2[100] ;

do
{

 textattr(NormalPen);
system ("cls") ; // clear screen

for (int i=0;i<6;i++)
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

printf("Enter Index from 1 to 10 \n");
scanf("%i",&index) ;
  system("cls") ;
printf("Enter Employee #%i \n" , index);

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
scanf("%i",&eArr[index].ID) ;
gotoxy(13 , 2+(1*3));
scanf("%s",&eArr[index].name);
gotoxy(13 , 2+(2*3));
scanf("%i",&eArr[index].age);
gotoxy(13 , 2+(3*3));
scanf("%s",&eArr[index].gender);
gotoxy(54 , 2+(0*3));
scanf("%s",&eArr[index].address);
gotoxy(54 , 2+(1*3));
scanf("%lf",&eArr[index].salary);
gotoxy(54 , 2+(2*3));
scanf("%lf",&eArr[index].overTime);
gotoxy(54 , 2+(3*3));
scanf("%lf",&eArr[index].deduct);


 _getch();

 break ;

    case 1: ///Display by ID
    system("cls") ;
printf("Please enter the employee ID") ;
scanf("%i",&ID2);
system("cls") ;
getEmployee(ID2);
  _getch();

break ;


case 2:  //Display All
    system("cls") ;
for(int i=0;i<10;i++)
    {
    if (eArr[i].salary !=0)
    {
    printf ("below information for employee %i" , i);
printf("\n");
printf("Employee Name : %s \n"  , eArr[i].name);
printf("Employee ID : %i \n",eArr[i].ID);
printf("Employee Net Salary : %lf \n",eArr[i].salary+eArr[i].overTime-eArr[i].deduct);
 }
}
_getch();

break ;

case 3: /// Delete by ID
        system("cls") ;
    printf("Please enter the Employee ID: ");
     scanf("%d",&ID2);
      system("cls") ;
deleteByID(ID2) ;
     _getch();
break ;

case 4: /// Delete by Name
           system("cls") ;
    printf("Please enter the Employee Name: ");
    scanf("%s",&name2) ;
      system("cls") ;
deleteByName(name2) ;
     _getch();

break ;


case 5: /// exit
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
                    current = 5 ;

            break;

             case 80 : // case down ascci

                 current++ ;
                if (current > 5)
                    current = 0 ;
            break;

             case 71 : // case home ascci
                 current = 0 ;
            break;

             case 79: // case end ascci
                  current = 5 ;
            break;
        }
}

} while (exitFlag == 0) ;

}

