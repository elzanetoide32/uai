#include <iostream>
using namespace std;
int main(){
    int Num_fact=0,Num_art=0,art1=0,Cant=0,Cant_vendida=0,Mayor_30=0;
    float Precio_unit,monto,total;

    printf("ingrese el numero de factura: ");
    scanf("%i",&Num_fact);
    while (Num_fact!=0)
    {
        printf("ingrese el N| del articulo: ");
        scanf("%i",&Num_art);
        if(Num_art==1){
            art1++;
        }
        printf("ingrese la cantidad vendida del producto: ");
        scanf("%i",&Cant_vendida);
        printf("ingrese el precio unitario: ");
        scanf("%f",&Precio_unit);

        monto=Cant_vendida*Precio_unit;
        total+=monto;
        if(monto>=30000){
            Mayor_30+=1;
        }
        printf("el valor de la factura es: %.2f \n",monto);
        
        printf("ingrese el numero de factura: ");
        scanf("%i",&Num_fact);
    }
    
    printf("la cantidad del art1 es: %i \n",art1);
    printf("la facturacion toal es: %.2f \n",total);
    printf("la cantidad de facturas > a 30k es: %i \n",Mayor_30);
    

    return 0;
}