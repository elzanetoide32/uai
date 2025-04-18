#include<iostream>
using namespace std;
int main()
{
    float valorH,hora,sueldo;
    printf("ingrese el valor de la hora: ");
    scanf("%f",&valorH);
    printf("ingrese las hora: ");
    scanf("%f",&hora);

    sueldo=hora*valorH;
    if(hora>=40){
        sueldo+=100000;
    }
    if(hora>=60){
        sueldo+=100000;
    }

    printf("su sueldo es: %.2f",sueldo);

    return 0;
} 
