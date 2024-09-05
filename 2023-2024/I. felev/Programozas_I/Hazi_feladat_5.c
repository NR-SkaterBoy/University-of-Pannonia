/**
 * Egészítsd ki az alábbi programot a megadott két helyen!
 * Az első kódrészlet olvassa be a tömb elemeit.
 * A második kódrészlet olvasson be egy új egész számot, majd jelenítse meg a tömbnek azon elemeit,
 * amelyek az új beolvasott számnál nagyobbak! Minden elem külön sorba jelenjen meg.
 */

#include <stdio.h>

int main()
{
    int szamok[15];
    int i;

    for (i = 0; i < 15; i++)
        scanf("%d", &szamok[i]);

    printf("Bekeres vege\n");

    int a;
    scanf("%d", &a);
    for (i = 0; i < 15; i++)
    {
        if (szamok[i] > a)
            printf("%d\n", szamok[i]);
    }

    return 0;
}

/**
 * Egészítsd ki az alábbi kódot úgy, hogy a program írja ki az tömb elemeit egy sorba, szóközzel elválasztva!
 */

#include <stdio.h>

int main()
{
    int tomb[5];
    for (int i = 0; i < 5; i++)
    {
        scanf("%d", &tomb[i]);
    }

    for (int i = 0; i < 5; i++)
    {
        printf("%d ", tomb[i]);
    }

    return 0;
}

/**
 * Készíts egy programot C nyelven, amely létrehoz és bekér egy 28 elemű, egész számokat tároló tömböt!
 * Ezután jelenítse meg a tömb elemeit egy sorban, vesszővel (és szóközzel) elválasztva!
 * Vessző csak az elemek előtt legyen, a sor elején és végén ne!
 */

#include <stdio.h>

int main()
{
    int tomb[28];
    int i;

    for (i = 0; i < 28; i++)
    {
        scanf("%d", &tomb[i]);
    }

    for (i = 0; i < 28; i++)
    {
        if (i == 0)
        {
            printf("%d", tomb[i]);
        }
        else
        {
            printf(", %d", tomb[i]);
        }
    }

    return 0;
}
