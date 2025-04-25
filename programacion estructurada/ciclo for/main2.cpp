#include <iostream>
using namespace std;
int main(){
    float total=0,nota;
    int count=0;
    printf("ingrese el N° de reps ");
    scanf("%i",&count);
    for(int i=0;i<count;i++){
        printf("ingrese la nota %i",i);
        scanf("%f",&nota);
        total+=nota;
    }
    printf("su promedioes: %f",(total/count));


    return 0;
}