#include<iostream>
using namespace std;
int main()
{
    float valor;
    printf("ingrese el valor: ");
    scanf("%f",&valor);

    if(valor>0){
        printf("es mayor a 0");
    }else if(valor<0){
        printf("el valor es menora 0");
    }else{
        printf("el valor es 0");
    }

    return 0;
} 
