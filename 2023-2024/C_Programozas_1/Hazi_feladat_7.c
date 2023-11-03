/**
 * Egy kertészetben, egy program feladata az, hogy egy függvény segítségével megállapítsa,
 * hogy hány darab ládára lesz szükség az almák tárolásához és, hogy ez mennyibe fog kerülni.
 * Készíts függvényt "ar" névvel ami paraméterként 3 számot vár:
 * Az első az almák darabszáma (előjeles egész)
 * A második a ládák kapacitása (előjel nélküli egész)
 * A harmadik pedig a ládák egységára (előjel nélküli egész)
 * A függvény számolja ki a ládák kapacitása alapján, hogy hány darab ládára lesz szükség az almák tárolására,
 * és térjen vissza a szükséges ládák összesített árával.
 * Pl.: Legyen 34 darab alma, amiket 10-es kapacitású ládákban tárolunk, amiknek az egységára 300Ft.
 * A számolás végén az jön ki, hogy 4 darab ládára lesz szükségünk (3 teli láda +1) ami így 4*300, azaz 1200Ft-ba fog kerülni.
 */

int ar(int db, unsigned kap, unsigned ar)
{
	int elad = 0;
	return elad = db % kap == 0 ? (db / kap) * ar : ((db / kap) + 1) * ar;
	/* Magyarázat:
	 * Azért adok +1 értéket hozzá, mert lényegtelen, hogy hány db alma marad, amíg nem lesz teli a láda
	 */
}

/**
 * Egy iskolában az alábbi program feladata az, hogy egy függvény segítségével a pontszám alapján meghatározza azt,
 * hogy a tanulók milyen jegyet kapnak a dolgozatukra.
 * A dolgozat 50 pontos. A függvény az alábbi szempontok alapján adja vissza az érdemjegyet.
 * 0-25 pont között 1-es
 * 26-31 pont között 2-es
 * 32-37 pont között 3-as
 * 38-43 pont között 4-es
 * 44 felett pedig 5-ös érdemjegyet adjon vissza
 * A main-ben hívd meg a függvényt a tömb aktuális elemére, és írasd ki az érdemjegyeket szóközzel elválasztva
 * Az egyes érdemjegyek szélsőértéke is az adott intervallumba tartozik (pl.: 31 pont 3-as lesz)
 */

#include <stdio.h>

unsigned erdemjegy(unsigned pont)
{
	// Ide írja a függvényt
	int pontszam = pont;
	if (pontszam >= 0 && pontszam <= 25)
	{
		return printf("1 ");
	}
	else if (pontszam >= 26 && pontszam <= 31)
	{
		return printf("2 ");
	}
	else if (pontszam >= 32 && pontszam <= 37)
	{
		return printf("3 ");
	}
	else if (pontszam >= 38 && pontszam <= 43)
	{
		return printf("4 ");
	}
	else
	{
		return printf("5 ");
	}
}

int main()
{
	unsigned dolgozatok[10];
	for (int i = 0; i < 10; i++)
	{
		scanf("%u", &dolgozatok[i]);
	}
	for (int i = 0; i < 10; i++)
	{
		// Hívja meg a függvényt, és írassa ki az eredményt
		erdemjegy(dolgozatok[i]);
	}
	printf("\n");
	return 0;
}