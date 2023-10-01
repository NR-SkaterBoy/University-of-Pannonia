/**
 * Függvények
 */

/**
 * Task 1
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
    if (pont >= 44)
        printf("5 ");
    else if (pont >= 38 && pont <= 43)
        printf("4 ");
    else if (pont >= 32 && pont <= 37)
        printf("3 ");
    else if (pont > 26 && pont <= 31)
        printf("2 ");
    else if (pont >= 0 && pont <= 25)
        printf("1 ");
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

/**
 * Task 2
 * Van egy "Termes" nevű struktúránk ami a következőket tartalmazza:
 * Termés neve (string)
 * Vétel ár (unsigned int)
 * Mennyiség (unsigned int)
 * Készíts függvényt "legjobb" névvel. A függvény várjon egy Termes típusú tömböt, és annak méretét.
 * A függvény írja ki annak a termésnek a nevét, amiből a legtöbbet tudja keresni a gazdaság (vétel ár*mennyiség).
 */

#include <stdio.h>

struct Termes
{
    char termes[15];
    unsigned ar, mennyiseg;
};

// Add meg a függvény paramétereit
void legjobb(
    struct Termes *tomb, int meret)
{
    // Ide jön a függvény
    int x[meret];
    for (int i = 0; i < meret; i++)
    {
        x[i] = tomb[i].ar * tomb[i].mennyiseg;
    }
    int max = 0;
    for (int i = 0; i < meret; i++)
    {
        if (x[i] > x[max])
            max = i;
    }
    printf("%s", tomb[max].termes);
}

int main()
{
    struct Termes tomb[5];
    for (int i = 0; i < 5; i++)
    {
        scanf("%s %u %u", tomb[i].termes, &tomb[i].ar, &tomb[i].mennyiseg);
    }
    legjobb(tomb, 5);
    return 0;
}

/**
 * Task 3
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

int ar(int darab, unsigned lada, unsigned ladaAr)
{

    if (darab % lada == 0)
    {
        lada = darab / lada;
        return lada * ladaAr;
    }

    else
    {
        lada = (darab / lada) + 1;
        return lada * ladaAr;
    }
}