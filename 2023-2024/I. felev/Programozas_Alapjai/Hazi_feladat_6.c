/**
 * Egészítse ki az alábbi kódot úgy, amely a benne_van változó értékét 1-re állítja,
 * ha a(z) keresettszam változóban tárolt szám szerepel a(z) ertekek tömbben.
 */

#include <stdio.h>

int main()
{
	int ertekek[10];
	int i;
	for (i = 0; i < 10; i++)
	{
		scanf("%d", &ertekek[i]);
	}
	int keresettszam;
	scanf("%d", &keresettszam);
	int benne_van;

	for (i = 0; i < 10; i++)
	{
		if (ertekek[i] == keresettszam)
		{
			benne_van = 1;
			break;
		}
	}

	if (benne_van == 1)
		printf("Van benne\n");
	else
		printf("Nincs benne\n");
	return 0;
}

/**
 * Egészítse ki az alábbi kódot úgy, hogy keresse meg a(z) bekert változóban tárolt számot a(z) szamok tömbben.
 * Amennyiben a szám szerepel a tömbben, a(z) talalat_helye változó értékét állítsa be az első találat indexére.
 * Amennyiben nem szerepel, úgy a(z) talalat_helye értéke legyen -1.
 */

#include <stdio.h>

int main()
{
	int szamok[10];
	int i;
	for (i = 0; i < 10; i++)
	{
		scanf("%d", &szamok[i]);
	}
	int bekert;
	scanf("%d", &bekert);
	int talalat_helye;

	for (i = 0; i < 10; i++)
	{
		if (szamok[i] == bekert)
		{
			talalat_helye = i;
			break;
		}
		else
			talalat_helye = -1;
	}

	if (talalat_helye == -1)
		printf("Nincs benne\n");
	else
		printf("Benne van, ezen az indexen: %d\n", talalat_helye);
	return 0;
}

/**
 * Készítsen C programot, amely bekér egy 15 elemű, egészeket tároló tömböt.
 * A program keresse meg a tömbben az első páros számot, és jelenítse meg az indexével együtt
 * (egy sorban két szám, az első az érték, a második az index). Amennyiben nincs a tömbben páros szám, úgy írja ki, hogy "Nincs".
 */

#include <stdio.h>
#define M 15

int main()
{
	int szamok[M];
	int i;
	int talaltIndex = -1;

	for (i = 0; i < M; i++)
	{
		scanf("%d", &szamok[i]);
	}

	for (i = 0; i < M; i++)
	{
		if (szamok[i] % 2 == 0)
		{
			talaltIndex = i;
			break;
		}
	}

	if (talaltIndex != -1)
	{
		printf("%d %d\n", szamok[talaltIndex], talaltIndex);
	}
	else
	{
		printf("Nincs\n");
	}

	return 0;
}

/**
 * Egészítsd ki az alábbi eljárást úgy, hogy a szamok tömbből válogassa ki a 100-nál nagyobb elemeket a valogatott tömbbe!
 */

#include <stdio.h>

int szamok[50];
int szamokDarab;
int valogatott[50];
int valogatottDarab;

void valogat()
{

	valogatottDarab = 0; // Inicializáljuk a kiválogatott tömb darabszámát

	for (int i = 0; i < szamokDarab; i++)
	{
		if (szamok[i] > 100)
		{
			valogatott[valogatottDarab] = szamok[i];
			valogatottDarab++;
		}
	}
}

int main()
{
	scanf("%d", &szamokDarab);
	int i;
	for (i = 0; i < szamokDarab; i++)
		scanf("%d", &szamok[i]);

	valogat();

	for (i = 0; i < valogatottDarab; i++)
		printf("%d ", valogatott[i]);
	printf("\n");

	return 0;
}