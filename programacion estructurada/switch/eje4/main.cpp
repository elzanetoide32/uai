#include <iostream>
using namespace std;
int main(){
    int NE,NA,CP,VP;
    float boleto,max,p1,p2,p3,p4,p5,p6,total,me1,me2,me3,me4,me5,me6;
    /*contadoressss*/
    int pa1,pa2,pa3,pe1,pe2,pe3,pe4,pe5,pe6,cvmax;
    pa1=pa2=pa3=0;
    pe1=pe2=pe3=pe4=pe5=pe6=0;
    me1=me2=me3=me4=me5=me6=0;
    bool f=0;

    printf("ingrese el Numero de empleados");
    scanf("%d",&NE);
    while(NE!=99){
        printf("ingrese Numero de aeropuerto");
        scanf("%d",&NA);
        printf("ingrese la cantida de pasajes que vendio");
        scanf("%d",&CP);
        printf("ingrese el valor del pasaje");
        scanf("%d",&VP);

        boleto=CP*VP;
        switch(NA){
            case 1:
                pa1+=CP;
                break;
            case 2:
                pa2+=CP;
                break;
            case 3:
                pa3+=CP;
                break;
            default:
                printf("se equivoco, ingrese lo de nuevo");
                break;
        }
        switch(NE){
            case 1:
                me1+=boleto;
                pe1+=1;
                break;
            case 2:
                me2+=boleto;
                pe2+=1;
                break;
            case 3:
                me3+=boleto;
                pe3+=1;
                break;
            case 4:
                me4+=boleto;
                pe4+=1;
                break;
            case 5:
                me5+=boleto;
                pe5+=1;
                break;
            case 6:
                me6+=boleto;
                pe6+=1;
                break;
            default:
                printf("se equivoco, ingrese lo de nuevo");
                break;
        }

        if(f=0){
            max=boleto;
        }else if(max<boleto){
            max=boleto;
        }
        
        if(boleto>500000){
            cvmax+=1;
        }

        printf("ingrese el Numero de empleados");
        scanf("%d",&NE);        
    }


    total= me1+me2+me3+me4+me5+me6;
    p1=(me1/total)*100;
    p2=(me2/total)*100;
    p3=(me3/total)*100;
    p4=(me4/total)*100;
    p5=(me5/total)*100;
    p6=(me6/total)*100;

    ///imprimir todo
    printf("la cantidad de pasaje que vendio cada aeropuerto es: \n");
    printf("aeropuerto 1: %i \n",pa1);
    printf("aeropuerto 2: %i \n",pa2);
    printf("aeropuerto 3: %i \n",pa3);

    printf("la cantidad de pasaje que vendio cada empleado es: \n");
    printf("empleado 1: %i \n",pe1);
    printf("empleado 2: %i \n",pe2);
    printf("empleado 3: %i \n",pe3);
    printf("empleado 4: %i \n",pe4);
    printf("empleado 5: %i \n",pe5);
    printf("empleado 6: %i \n",pe6);

    printf("el monto por cada empleado es: \n");
    printf("empleado 1: %.2f \n",me1);
    printf("empleado 2: %.2f \n",me2);
    printf("empleado 3: %.2f \n",me3);
    printf("empleado 4: %.2f \n",me4);
    printf("empleado 5: %.2f \n",me5);
    printf("empleado 6: %.2f \n",me6);

    printf("el boleto de mayor valor es: %.2f \n",max);
    printf("la cantidad de ventas que superaron los 500000 es: %i \n",cvmax);

    printf("lo vendido por el empleado representa: \n");
    printf("empleado 1: %.2f \n",p1);
    printf("empleado 2: %.2f \n",p2);
    printf("empleado 3: %.2f \n",p3);
    printf("empleado 4: %.2f \n",p4);
    printf("empleado 5: %.2f \n",p5);
    printf("empleado 6: %.2f \n",p6);
    return 0;
}