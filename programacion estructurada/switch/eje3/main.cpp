#include <iostream>
using namespace std;
int main(){
    int n;
    float temp;
    float max=0,min=0;
    printf("ingrese cuantas temperaturas son: ");
    scanf("%d",&n);

    for(int i=1;i<=n;i++){
        printf("ingrese temperatura: ");
        scanf("%f",&temp);
        if(i==1){
            max=temp;
            min=temp;
        }

        if(temp>max){
            max=temp;
        }
        if(temp<min){
            min=temp;
        }
    }

    printf("la maxima fue de: %.2f",max);
    printf(" la minima fue de: %.2f",min);

    return 0;
}