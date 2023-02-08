#include <iostream>

using namespace std;

int main()
{
      int a,b ;
    scanf("%d" ,&a );
     scanf("%d" ,&b );


    for(int a ; a <= b ;a++)
    {
 if(a==1)
    printf("one");
    else if (a==2)
      printf("two");
     else if (a==3)
      printf("three");
     else if (a==4)
      printf("four");
     else if (a==5)
      printf("five");
     else if (a==6)
      printf("six");
     else if (a==7)
      printf("seven");
     else if (a==8)
      printf("eight");
     else if (a==9)
      printf("nine");

     else {
            if(a%2==0)
            printf("even");
            else printf("odd");
        }

    }




    return 0;
}
