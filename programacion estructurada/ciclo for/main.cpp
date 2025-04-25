#include <iostream>
using namespace std;
int main(){
    float total=0,nota;
    int count=0;
    for(int i=0;i<10;i++){
        printf("ingrese la nota %i",i);
        scanf("%f",&nota);
        total+=nota;
        count++;
    }
    printf("su promedioes: %f",(total/count));


    return 0;
}