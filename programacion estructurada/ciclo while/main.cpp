#include <iostream>
using namespace std;
int main(){
    int cant=0;
    float total=0,nota=0;
    printf("ingrese la nota");
    scanf("%f",&nota);
    while(nota!=0){
        total+=nota;
        cant++;

        printf("ingrese la nota ");
        scanf("%f",&nota);
    }
    printf("su promedioes: %.2f",(total/cant));
    return 0;
}