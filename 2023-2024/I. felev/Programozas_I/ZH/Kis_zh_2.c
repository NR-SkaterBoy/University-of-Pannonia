/**
 * Készíts egy programot, amely bekér egy 18 elemű, dupla lebegőpontos típusú számokat tároló tömböt,
 * majd megjeleníti a beolvasott értékeket a minta szerint!
 */

#include <stdio.h>
#define M 18

int main()
{
	float t[M];
	for (int i = 0; i < M; i++)
		scanf("%f", &t[i]);
	for (int i = 0; i < M; i++)
		printf("%d. elem: %.2f\n", i, t[i]);
}

/**
 * Egészítsd ki az alábbi programot úgy, hogy határozza meg és írja ki a(z) sokszam tömb azon elemeinek összegét,
 * melyek nagyobbak, mint 53!
 * A különböző teszt esetekben a tömb mérete is változik, így fontos a MERET használata fix érték helyett.
 */

#include <stdio.h>
#define MERET 8

int main()
{
	int sokszam[MERET] = {23, 54, 12, 64, 13, 12, 54, 45};
	int a = 0;
	for (int i = 0; i < MERET; i++)
		if (sokszam[i] > 53)
			a += sokszam[i];
	printf("Az osszeg: %d", a);

	return 0;
}

/**
 * Egészítsd ki az alábbi programot úgy, hogy írja ki, a két tömb közül melyikben van több olyan elem, ami kisebb, mint 85!
 * A különböző teszt esetekben a tömb mérete is változik, így fontos a MERET használata fix érték helyett.
 */

#include <stdio.h>

#define MERET 8

int main()
{
	int sokszam[MERET] = {23, 54, 12, 64, 13, 12, 54, 45};
	int szamlista[MERET] = {54, 23, 65, 87, 12, 87, 98, 12};

	int a = 0, b = 0, i = 0;
	for (i = 0; i < MERET; i++)
		if (sokszam[i] < 85)
			a++;
	for (i = 0; i < MERET; i++)
		if (szamlista[i] < 85)
			b++;

	if (a > b)
		printf("az elsoben van tobb");
	else if (b > a)
		printf("a masodikban van tobb");
	else
		printf("ugyanannyi van mindkettoben");

	return 0;
}