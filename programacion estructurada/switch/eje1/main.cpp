/*## ingrese los N° de empleados y su correspondiente cat sabiendo que los datos finalizan con empleado=0, se desea saber la cantidad de empleados x cat, teniendo en cuenta q son 4 cat*/
#include <iostream>
using namespace std;
int main(){
    float emp;
    int c1,c2,c3,c4,cat;
    c1=c2=c3=c4=0;
    printf("ingrese el numero de empleado: ");
    scanf("%d",&emp);

    while(emp!=0){
        printf("ingrese la categoria: ");
        scanf("%d",&cat);
        switch (cat)
        {
        case 1:
            c1+=1;
            break;
        case 2:
            c2+=1;
            break;
        case 3:
            c3+=1;
            break;
        case 4:
            c4+=1;
            break;
        
        default:
            printf("incorrecto ");
            break;
        }

        printf("ingrese el numero de empleado: ");
        scanf("%d",&emp);
    }

    printf("hay %d empleados en la categoria 1 \n",c1);
    printf("hay %d empleados en la categoria 2 \n",c2);
    printf("hay %d empleados en la categoria 3 \n",c3);
    printf("hay %d empleados en la categoria 4 \n",c4);
    return 0;
}