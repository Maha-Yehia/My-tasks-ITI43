#include <stdio.h>
#include <stdlib.h>

int main()
{
int x;
printf("Please enter a number from 1 to 3\n");
    scanf("%i",&x);

    switch(x)
    {
        case 1 :
            printf("Apple");
            break;

          case 2 :
            printf("Banana");
            break;

            case 3 :
            printf("Orange");
            break;
    }



    return 0;
}
