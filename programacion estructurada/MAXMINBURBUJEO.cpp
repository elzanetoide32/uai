#include <stdio.h>


int main()
{
	int AUTOS = 6;
	int tiempo, MIN, AUX, MAX, AUX2, VT[AUTOS+1], VAUX[AUTOS+1], AUX3, AUX4;
	
	for(int i=1; i<=AUTOS; i++)
	{
	printf("Ingrese el tiempo que hizo el auto numero %d  ", i);
	scanf("%d", &tiempo);
	VT[i]= tiempo;	
	}	
	
	//PUNTO A
	MIN = VT[1];
	AUX = 1;
	for(int i=2; i<=AUTOS; i++)
	{
			if(MIN>VT[i])
			{
				MIN = VT[i];
				AUX = i;
			}
	}
	
	printf("El auto ganador es el %d con %d minutos\n", AUX, MIN);
	
	
	//PUNTO B
	MAX = VT[1];
	AUX2 = 1;
	for(int i=2; i<=AUTOS; i++)
	{
		if(MAX<VT[i])
		{
			MAX = VT[i];
			AUX2 = i;
		}
	}
	
	printf("El auto que llego ultimo es el %d con %d minutos\n", AUX2, MAX);
	
	
	//PUNTO C
	for(int i=1; i<=AUTOS; i++)
	{
			VAUX[i] = i;
	}
	
		for(int i=1; i<AUTOS; i++)
		{
				for(int j=i+1; j<=AUTOS; j++)
				{
					if(VT[i]>VT[j])
					{
						AUX3 = VT[i];
						VT[i] = VT[j];
						VT[j] = AUX3;
						
						AUX4 = VAUX[i];
						VAUX[i] = VAUX[j];
						VAUX[j] = AUX4;		
					}
				}
		}
	
for(int i=1; i<=AUTOS; i++)
{
	printf("El auto %d llego con tiempo %d\n", VAUX[i], VT[i]);
}
	
	return 0;

}
