/**
 * Komplex struktúrás feladatok
 */

/**
 * Task 1
 * Készíts egy programot C nyelven, amely bekéri 12 darab esemény adatait!
 * A megjelenítendő adatok formátuma a példakimenetben látható (az üres sorok is fontosak).
 * Minden eseményhez tároljuk a nevét (szöveg, legfeljebb 30 karakter), az idejét (év, hónap, nap), valamint a résztvevők számát!
 * A bekérés után jelenjen meg minden esemény minden adata!
 * Jelenítsd meg, hogy mennyi olyan esemény van, amelyiket 2022 júliusában rendeztek!
 * Jelenítsd meg a legtöbb résztvevőt felsorakoztató esemény nevét!
 */

#include <stdio.h>

struct esemeny
{
    char nev[30];
    int ev;
    int honap;
    int nap;
    int db;
};
int main()
{
    struct esemeny adatok[12];
    int i;
    for (i = 0; i < 12; i++)
    {
        scanf("%s %d %d %d %d\n", adatok[i].nev, &adatok[i].ev, &adatok[i].honap, &adatok[i].nap, &adatok[i].db);
    }
    printf("Minden adat:\n");
    for (i = 0; i < 12; i++)
    {
        printf("%s: ev: %d, honap: %d, nap: %d, resztvevok: %d\n", adatok[i].nev, adatok[i].ev, adatok[i].honap, adatok[i].nap, adatok[i].db);
    }
    int db = 0;
    int maxindex = 0;
    for (i = 0; i < 12; i++)
    {
        if ((adatok[i].ev == 2022) && (adatok[i].honap == 7.))
            db++;
        if (adatok[i].db > adatok[maxindex].db)
            maxindex = i;
    }
    printf("\nEsemenyek 2022 juliusban: %d\n", db);
    printf("\nA legtobb resztvevovel lezajlo esemeny: %s", adatok[maxindex].nev);
    return 0;
}

/**
 * Task 2
 * Készíts egy programot C nyelven, amely beolvassa és eltárolja 8 társasjáték adatait!
 * A program kimenete kövesse a példában látható kimenetet, az üres sorok is fontosak.
 * A lebegőpontos értékek csak 1 tizedesjeggyel jelenjenek meg!
 * Minden játékhoz tároljuk a nevét (max 50 karakter), a megjelenési évét, az átlagos értékelését (ez lebegőpontos),
 * valamint a minimum és maximum játékos számot, amennyien lehet játszani a játékot!
 * A bekérés után jelenítsd meg a beolvasott adatokat!
 * Listázd ki az összes olyan játék nevét, amelyik játszható 5 fővel!
 * Keresd meg a legrégebbi játékot a listában (ha több egyforma is van, akkor a sorban az elsőt), és jelenítsd meg a nevét!
 * Rendezd a játékokat az értékelésük szerinti csökkenő sorrendbe, majd jelenítsd meg az új sorrendet!
 * Feltehetjük, hogy nem lesz kettő egyforma értékelés.
 */

#include <stdio.h>

struct tarsasjatek
{
    char nev[50];
    unsigned ev;
    double ertekeles;
    unsigned minfo;
    unsigned maxfo;
};
int main()
{
    struct tarsasjatek adatok[8];
    int i;
    for (i = 0; i < 8; i++)
    {
        scanf("%s %u %lf %u %u", adatok[i].nev, &adatok[i].ev, &adatok[i].ertekeles, &adatok[i].minfo, &adatok[i].maxfo);
    }
    printf("A beolvasott adatok:\n");
    for (i = 0; i < 8; i++)
    {
        printf("%s (%u): ertekeles: %.1lf, jatekosok szama: %u-%u\n", adatok[i].nev, adatok[i].ev, adatok[i].ertekeles, adatok[i].minfo, adatok[i].maxfo);
    }
    printf("\n");
    printf("Az 5 fovel jatszhato jatekok:\n");
    int minindex = 0;
    for (i = 0; i < 8; i++)
    {
        if (adatok[i].maxfo > 4)
            printf("%s\n", adatok[i].nev);
        if (adatok[i].ev < adatok[minindex].ev)
            minindex = i;
    }
    printf("\n");
    printf("A legregebbi jatek: %s\n", adatok[minindex].nev);
    int j;
    struct tarsasjatek temp;
    for (int i = 0; i < 7; i++)
    {
        for (j = i + 1; j < 8; j++)
        {
            if (adatok[i].ertekeles < adatok[j].ertekeles)
            {
                temp = adatok[i];
                adatok[i] = adatok[j];
                adatok[j] = temp;
            }
        }
    }
    printf("\n");
    printf("A rendezett jateklista:\n");
    for (i = 0; i < 8; i++)
    {
        printf("%s (%u): ertekeles: %.1lf, jatekosok szama: %u-%u\n", adatok[i].nev, adatok[i].ev, adatok[i].ertekeles, adatok[i].minfo, adatok[i].maxfo);
    }
    return 0;
}