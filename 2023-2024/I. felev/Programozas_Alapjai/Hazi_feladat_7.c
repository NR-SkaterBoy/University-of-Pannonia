/**
 * Készíts egy programot C nyelven, amelyik eltárolja egy lakás gázfogyasztását (lebegőpontos értékek) egy hónap első két hetére
 * (14 napra) vonatkozóan. A program olvassa be az adatokat, majd a minta szerint jelenítse meg a következő válaszokat:
 * Melyik napon volt a legkisebb, illetve a legnagyobb a fogyasztás (a napok számozását 1-től kezdjük a kiírásnál)?
 * Mi volt az átlag fogyasztás a két hét alatt?
 * Végül jelenítse meg a fogyasztásokat csökkenő sorrendbe rendezve!
 */

#include <stdio.h>
#define N 14

int main()
{
	float fogyasztas[N];
	float atlag = 0;
	float min_fogyasztas = 0;
	float max_fogyasztas = 0;
	int min_nap = 1;
	int max_nap = 1;

	for (int i = 0; i < N; i++)
	{
		scanf("%f", &fogyasztas[i]);
		atlag += fogyasztas[i];

		if (i == 0 || fogyasztas[i] < min_fogyasztas)
		{
			min_fogyasztas = fogyasztas[i];
			min_nap = i + 1;
		}
		if (i == 0 || fogyasztas[i] > max_fogyasztas)
		{
			max_fogyasztas = fogyasztas[i];
			max_nap = i + 1;
		}
	}

	atlag /= 14;
	printf("A legkisebb fogyasztas az %d. napon volt: %.2f\n", min_nap, min_fogyasztas);
	printf("A legnagyobb fogyasztas az %d. napon volt: %.2f\n", max_nap, max_fogyasztas);
	printf("------\n");
	printf("Atlagos fogyasztas a ket het alatt: %.2f\n", atlag);

	printf("------\n");

	printf("Az adatok csokkeno sorrendben:\n");
	for (int i = 0; i < N; i++)
	{
		for (int j = i + 1; j < 14; j++)
		{
			if (fogyasztas[i] < fogyasztas[j])
			{
				float temp = fogyasztas[i];
				fogyasztas[i] = fogyasztas[j];
				fogyasztas[j] = temp;
			}
		}
		printf("%.2f\n", fogyasztas[i]);
	}

	return 0;
}
