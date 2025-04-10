#include<iostream>
using namespace std;
int main(){
    int sueldo_fijo=300000,valor_inscripciones=50000,insc,ventas;
    float sueldo=0,bono=0;
    printf("ingrese la cantidad de inscripciones que hiso: ");
    scanf("%i",&insc);

    ventas=valor_inscripciones*insc;
    bono=ventas*0.1;
    sueldo=sueldo_fijo+ventas+bono;
    printf("su sueldo es de: %.2f \n",sueldo);


    return 0;
}