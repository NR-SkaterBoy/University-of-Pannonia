/**
 * Készíts egy programot C nyelven, amely bekér 20 darab egész számot egy tömbbe,
 * és utána a minta szerinti módon megjeleníti a páros elemeket!
 */

#include <stdio.h>

int main()
{
    int tomb[20], cnt = 1;
    for (int i = 0; i < 20; i++)
        scanf("%d", &tomb[i]);
    for (int i = 0; i < 20; i++)
    {
        if (tomb[i] % 2 == 0)
        {
            printf("%d. egesz szam: %d\n", cnt, tomb[i]);
            cnt++;
        }
    }
}

/**
 * Készíts egy programot C nyelven, amely bekér kettő darab 10 elemű, egész számokat tároló tömböt
 * (először az egyiket teljesen, majd a másikat)! Ezután a program írjon ki 10 sort, mindegyikben 2 számmal.
 * Az első számok a sorban az első tömb elemei legyenek sorrendben, a második számok pedig a második tömb elemei fordított sorrendben.
 */

#include <stdio.h>

int main()
{
    int tomb1[10], tomb2[10];
    for (int i = 0; i < 10; i++)
        scanf("%d", &tomb1[i]);
    for (int i = 0; i < 10; i++)
        scanf("%d", &tomb2[i]);
    for (int i = 0; i < 10; i++)
        printf("%d %d\n", tomb1[i], tomb2[9 - i]);
    return 0;
}

/**
 * Egészítsd ki az alább programot úgy, hogy a kimenetre a tömb azon elemeinek összegét írja ki, amelyek osztható a(z) 2 értékkel.
 */

#include <stdio.h>

int main()
{
    int array[25];
    int i;
    for (i = 0; i < 25; i++)
        scanf("%d", &array[i]);
    int osszeg = 0;
    for (i = 0; i < 25; i++)
    {
        if (array[i] % 2 == 0)
            osszeg += array[i];
    }
    printf("%d\n", osszeg);
    return 0;
}

/**
 * Készíts egy C programot, amely létrehoz és beolvas egy 14 elemű, egészeket tároló tömböt.
 * A program határozza meg azon elemek összegét, amelyek nagyobbak, mint -9, majd jelenítse meg ezt az összeget.
 */

#include <stdio.h>

int main()
{
    int array[14];
    int i;
    for (i = 0; i < 14; i++)
        scanf("%d", &array[i]);

    int osszeg = 0;
    for (i = 0; i < 14; i++)
    {
        if (array[i] > -9)
            osszeg += array[i];
    }

    printf("%d\n", osszeg);

    return 0;
}

/**
 * Adott egy MERET elemszámú tömb (szamok), és kettő egész változó (bal, jobb).
 * A program írja ki, hogy a tömbnek mennyi, bal és jobb közötti eleme van.
 * Feltehetjük, hogy bal mindig kisebb, mint jobb (a két érték maga ne számítson bele).
 */

#include <stdio.h>

#define MERET 5

int main()
{
    int szamok[MERET];
    int i;
    for (i = 0; i < MERET; i++)
        scanf("%d", &szamok[i]);
    int bal, jobb;
    scanf("%d%d", &bal, &jobb);

    int db = 0;
    for (int i = 0; i < MERET; i++)
    {
        if (szamok[i] > bal && szamok[i] < jobb)
        {
            db++;
        }
    }

    printf("%d", db);

    return 0;
}

/**
 * Egészítse ki az alábbi kódot, hogy kiírja a tömb nem negatív elemeinek számát.
 */

#include <stdio.h>

int main()
{
    int tomb[5];
    for (unsigned i = 0; i < 5; i++)
    {
        scanf("%i", &tomb[i]);
    }
    unsigned db = 0;
    for (unsigned i = 0; i < 5; i++)
    {
        if (
            tomb[i] >= 0)
            db++;
    }
    printf("%u", db);
    return 0;
}