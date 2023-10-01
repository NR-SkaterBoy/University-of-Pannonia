/**
 * Struktúra
 */

/**
 * Task 1
 * Egészítsd ki az alábbi kódot úgy, hogy elvégezze a vizallasok tömb megfelelő bekérését, majd kiírását a minta szerint!
 */

#include <stdio.h>

struct vizallasAdat
{
    char helyszin[50];
    int mertErtekek[10];
};

int main()
{
    struct vizallasAdat vizallasok[4];

    // bekérés:

    for (int i = 0; i < 4; i++)
    {
        scanf("%s", vizallasok[i].helyszin);
        for (int j = 0; j < 10; j++)
        {
            scanf("%d", &vizallasok[i].mertErtekek[j]);
        }
    }

    int vege;
    scanf("%d", &vege);

    // kiírás:
    printf("KIIRAS:\n");

    for (int i = 0; i < 4; i++)
    {
        printf("%s:", vizallasok[i].helyszin);
        for (int j = 0; j < 10; j++)
        {
            printf(" %d", vizallasok[i].mertErtekek[j]);
        }
        printf("\n");
    }

    printf("vege ellenorzes: %d\n", vege);

    return 0;
}

/**
 * Task 2
 * Készíts egy programot C nyelven, amely bekéri 15 darab doboz adatait
 * (szélesség, magasság, hosszúság, lebegőpontos értékek), illetve bekér még egy lebegőpontos számot!
 * A program ezután jelenítse meg az első olyan doboz indexét, amelynek térfogata nagyobb a végén bekért számnál!
 * Ha nincs ilyen, akkor a "NINCS" felirat jelenjen meg a kimeneten!
 */

#include <stdio.h>

struct dobozAdat
{
    double szelesseg;
    double magassag;
    double hosszusag;
};

int main()
{
    struct dobozAdat adatok[15];
    for (int i = 0; i < 15; i++)
        scanf("%lf %lf %lf", &adatok[i].szelesseg, &adatok[i].magassag, &adatok[i].hosszusag);

    double meret;
    scanf("%lf", &meret);

    int sor = -1;
    for (int i = 0; i < 15; i++)
    {
        if ((adatok[i].szelesseg * adatok[i].magassag * adatok[i].hosszusag) > meret)
        {
            sor = i;
            break;
        }
    }

    if (sor > -1)
        printf("%d", sor);
    else
        printf("NINCS");

    return 0;
}

/**
 * Task 3
 * Egészítsd ki az alábbi kódot úgy, hogy elvégezze a vizsgalatok tömb megfelelő bekérését, majd kiírását a minta szerint!
 */

#include <stdio.h>

struct datum
{
    int ev, honap, nap;
};

struct cim
{
    char telepules[50];
    int iranyitoSzam;
    char utca[50];
    int hazszam;
};

struct ellenorzesLista
{
    struct cim helyszin;
    struct datum idopontok[5];
};

int main()
{
    struct ellenorzesLista vizsgalatok[3];

    // bekérés:

    for (int i = 0; i < 3; i++)
    {
        scanf("%s %d %s %d", vizsgalatok[i].helyszin.telepules, &vizsgalatok[i].helyszin.iranyitoSzam, vizsgalatok[i].helyszin.utca, &vizsgalatok[i].helyszin.hazszam);
        for (int j = 0; j < 5; j++)
        {
            scanf("%d %d %d", &vizsgalatok[i].idopontok[j].ev, &vizsgalatok[i].idopontok[j].honap, &vizsgalatok[i].idopontok[j].nap);
        }
    }

    int vege;
    scanf("%d", &vege);

    // kiírás:
    printf("KIIRAS:\n");

    for (int i = 0; i < 3; i++)
    {
        printf("Helyszin: %s (%d) %s utca %d\nVizsgalat idopontok:\n", vizsgalatok[i].helyszin.telepules, vizsgalatok[i].helyszin.iranyitoSzam, vizsgalatok[i].helyszin.utca, vizsgalatok[i].helyszin.hazszam);
        for (int j = 0; j < 5; j++)
        {
            printf("ev: %d, honap: %d, nap: %d\n", vizsgalatok[i].idopontok[j].ev, vizsgalatok[i].idopontok[j].honap, vizsgalatok[i].idopontok[j].nap);
        }
    }

    printf("vege ellenorzes: %d\n", vege);

    return 0;
}

/**
 * Task 4
 * Egy célba dobó verseny szervezésére készítünk programot. A verseny 6 fordulóból áll,
 * minden körben minden játékos szerez egy 0 és 100 közötti (egész) pontszámot. A versenyzők
 * végső pontja a 6 kör alatt elért pontjaik közül a legnagyobb. Készítsd el a programot C nyelven,
 * amely bekéri egy ilyen verseny 10 résztvevőjének nevét és pontszámait (feltehetjük, hogy a névben nincs szóköz,
 * és a megadott pontszámok is mindig helyesek)! A bekérés után jelenítsd meg a verseny eredményét
 * (a versenyzők nevét és végső pontszámát a pontok szerinti csökkenő sorrendben), a minta szerint!
 * A megoldás során feltehető, hogy két egyforma pontszám nem lesz, így azzal nem kell külön foglalkozni.
 */

#include <stdio.h>
#include <limits.h>

struct versenyzo
{
    char nev[50];
    int pontok[6];
    int max;
};

int main()
{
    int prev_max, max, max_idx;

    struct versenyzo adatok[10];

    for (int i = 0; i < 10; i++)
    {
        scanf("%s", adatok[i].nev);

        adatok[i].max = -1;

        for (int j = 0; j < 6; j++)
        {
            scanf("%d", &adatok[i].pontok[j]);

            if (adatok[i].max < adatok[i].pontok[j])
            {
                adatok[i].max = adatok[i].pontok[j];
            }
        }
    }

    max = INT_MAX;
    for (int i = 0; i < 10; i++)
    {
        prev_max = max;
        max = -1;

        for (int j = 0; j < 10; j++)
        {
            if (adatok[j].max > max && adatok[j].max < prev_max)
            {
                max = adatok[j].max;
                max_idx = j;
            }
        }

        printf("%d. helyezett: %s, %d pont\n", i + 1, adatok[max_idx].nev, max);
    }

    return 0;
}