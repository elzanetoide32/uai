#include<iostream>
#include<math.h>
using namespace std;
int main(){
    int lado1,lado2;
    float hipo,perimetro,supr;

    printf("ingrese un lado: ");
    scanf("%i",&lado1);
    printf("ingrese otro lado: ");
    scanf("%i",&lado2);

    hipo=sqrt(pow(lado1,2)+pow(lado2,2));
    perimetro=lado1+lado2+hipo;
    supr=(lado1*lado2)/2;

    printf("la hipotenusa es: %.2f\n",hipo);
    printf("el perimetro es: %.2f\n",perimetro);
    printf("la superficie es: %.2f\n",supr);

    return 0;
}