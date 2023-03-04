/**
 * Ciklusok, tömbök
*/

/**
 * Task 1
 * Egészítsd ki az alábbi kódot, hogy a szam változó értékét mindig felezze meg, egészen addig, amíg páratlan számot nem kap.
 */

#include <stdio.h>

int main()
{
    int szam;
    scanf("%d", &szam);

    if (szam % 2 == 0)
    {
        while (szam % 2 == 0)
        {
            szam /= 2;
        }
    }

    printf("%d\n", szam);
    return 0;
}

/**
 * Task 2
 * Készíts egy programot C nyelven, amely folyamatosan kér be egész számokat egészen addig
 *  amíg az értékek folyamatosan növekednek! A program álljon le,
 * ha az éppen beolvasott érték kisebb, mint az előző
 * (egyenlőség esetén még folytatódjon a bekérés), és írja ki, hogy "VEGE",
 * majd egy szóközzel utána az utoljára beolvasott értéket! Az első beolvasott érték bármi lehet.
 */

#include <stdio.h>

int main()
{
    int a, b;
    scanf("%d", &b);
    do
    {
        a = b;
        scanf("%d", &b);
    } while (a <= b);
    printf("VEGE %d", b);
}

/**
 * Task 3
 * Készíts egy programot C nyelven, amely beolvas egy egész számot, majd '#' karakterek segítségével
 * megjelenít egy háromszög mintát, az alábbiak szerint:
 * Az első sorban 1 karakter
 * Minden későbbi sorban eggyel több (2, 3, 4, ...), egészen, míg el nem érjük a beolvasott értéket.
 * Ezután meg kell csinálni ugyanezt fordított irányban, de a leghosszabb sort nem kell megismételni, csak a többit.
 */

#include <stdio.h>

int main()
{
    int a;
    scanf("%d", &a);
    char character = '#';

    for (int i = 2; i <= a; i++)
    {
        for (int j = 0; j <= i - 2; j++)
        {
            printf("%c", character);
        }
        printf("\n");
    }

    for (int i = a; i >= 1; --i)
    {
        for (int j = 1; j <= i; ++j)
        {
            printf("%c", character);
        }
        printf("\n");
    }
}

/**
 * Task 4
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
 * Task 5
 * Készíts egy programot C nyelven, amely létrehoz és bekér egy 28 elemű,
 * egész számokat tároló tömböt! Ezután jelenítse meg a tömb elemeit egy sorban, vesszővel
 * (és szóközzel) elválasztva! Vessző csak az elemek előtt legyen, a sor elején és végén ne!
 */

#include <stdio.h>

int main()
{
    int tomb[28];
    for (int i = 0; i < 28; i++)
    {
        scanf("%d", &tomb[i]);
    }

    for (int i = 0; i < 28; i++)
    {
        if (i != 27)
            printf("%d, ", tomb[i]);
        else
            printf("%d", tomb[i]);
    }
}

/**
 * Task 6
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
    {
        scanf("%d", &szamok[i]);
    }

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