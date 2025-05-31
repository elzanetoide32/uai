#include<iostream>
using namespace std;
int main(){
    int DNI,edad,MinEdad,AUX,MaxLevel;
    float total,pf,pm;
    int NE,LR,Sexo;
    int cp,cc,cf,cm,np,ns,nt,f;
    cp=cc=0;
    cf=cm=0;
    np=ns=nt=0;
    f=0;

    printf("ingrese el DNI: ");
    scanf("%d",&DNI);
    while(DNI!=0){
        printf("ingrese el Nivel de estudio, 1 primaria, 2 secundaria, 3 terciario: ");
        scanf("%d",&NE);
        printf("ingrese el Lugar de residencia, 1 para ciudad 2 para prov: ");
        scanf("%d",&LR);
        printf("ingrese el sexo, 1 femenino, 2 masculino: ");
        scanf("%d",&Sexo);
        printf("ingrese la edad: ");
        scanf("%d",&edad);
        if(f==0){
            AUX=DNI;
            MinEdad=edad;
            f=1;
        }else if(MinEdad>edad){
            MinEdad=edad;
            AUX=DNI;
        }
        switch (LR)
        {
            case 1:
                cc+=1;
                break;
            case 2:
                cp+=1;
                break;
            default:
                printf("valor incorrecto");
                break;
        }
        switch (Sexo)
        {
            case 1:
                cf+=1;
                break;
            case 2:
                cm+=1;
                break;
            default:
                printf("valor incorrecto");
                break;
        }

        switch (NE)
        {
            case 1:
                np+=1;
                break;
            case 2:
                ns+=1;
                break;
            case 3:
                nt+=1;
                break;
            default:
                printf("valor incorrecto");
                break;
        }
        printf("ingrese el DNI: ");
        scanf("%d",&DNI);
    }
    total=cf+cm;
    pf=(cf*100)/total;
    pm=(cm*100)/total;

    if(np>ns&&np>nt){
        MaxLevel=1;
    }else if(ns>np&&ns>nt){
        MaxLevel=2;
    }else{
        MaxLevel=3;
    }
    printf("la minima edad es: %d, y del alumno: %d",MinEdad,AUX);
    printf("la cantidad de alumnos de Ciudad: %d",cc);
    printf("la cantidad de alumnos de Provincia: %d",cp);
    printf("el porcentaje femenino es: %.2f",pf);
    printf("el porcentaje masculino es: %.2f",pm);
    printf("el nivel maximo es: %d",MaxLevel);
    return 0;
}