#include <stdio.h>

int main()
{
	float vnota[5];
	int vedad[5];
	float promedio, prom30, total, nota;
	int aplazados, aprobados, cant, edad;
	aplazados = aprobados = cant = total = vnota[0]	= 0; 
	
	for(int i=1; i<=4; i++)
	{
		printf("Ingrese la nota del alumno %d ", i);
		scanf("%f", &nota);
		printf("Ingrese la edad del alumno %d ", i);
		scanf("%d", &edad);
		
		vnota[i] = nota;
		vedad[i] = edad;
	} //Ceramo el for ese
	
	
	//PUNTO A
	for(int i=1; i<=4; i++)
	{
		vnota[0] = vnota[0] + vnota[i];
	}
	promedio = vnota[0] / 4;
	printf("El promedio general de notas es de %.2f\n", promedio);
	
	//PUNTO B
	for(int i=1; i<=4; i++)
	{
		if(vnota[i]<4)
		{
			aplazados ++;
		}
	}
	printf("La cantidad de aplazados es de %d\n", aplazados);
	
	//PUNTO C
	for(int i=1; i<=4; i++)
	{
		if(vnota[i]>6)
		{
			aprobados ++;
		}
	}
	printf("La cantidad de promocionados es de %d\n", aprobados);
	
	//PUNTO D
	for(int i=1; i<=4; i++)
	{
		if(vedad[i]>30)
		{
			cant = cant +1;
			total = total + vnota[i];
		}
	}
	prom30 = total/cant;
	printf("El promedio de nota de los mayores de 30 es de %.2f \n", prom30);
	
	return 0;
}
