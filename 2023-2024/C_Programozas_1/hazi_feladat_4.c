/**
 * Egészítsd ki az alábbi kódot, hogy a szam változó értékét mindig felezze meg, egészen addig, amíg páratlan számot nem kap.
 */

#include <stdio.h>

int main()
{
    int szam;
    scanf("%d", &szam);

    while (szam % 2 == 0)
        szam /= 2;

    printf("%d\n", szam);
    return 0;
}

/**
 * Készíts egy programot C nyelven, amely folyamatosan kér be egész számokat egészen addig, amíg az értékek folyamatosan növekednek!
 * A program álljon le, ha az éppen beolvasott érték kisebb, mint az előző (egyenlőség esetén még folytatódjon a bekérés), és írja ki,
 * hogy "VEGE", majd egy szóközzel utána az utoljára beolvasott értéket! Az első beolvasott érték bármi lehet.
 */

#include <stdio.h>

int main()
{
    int prev, curr;
    scanf("%d", &prev);

    while (1)
    {
        scanf("%d", &curr);

        if (curr < prev)
        {
            printf("VEGE %d\n", curr);
            break;
        }

        prev = curr;
    }

    return 0;
}


/**
 * Készíts egy programot C nyelven, amely beolvas egy egész számot, majd '#' karakterek segítségével megjelenít egy háromszög mintát,
 * az alábbiak szerint:
 * Az első sorban 1 karakter
 * Minden későbbi sorban eggyel több (2, 3, 4, ...), egészen, míg el nem érjük a beolvasott értéket.
 * Ezután meg kell csinálni ugyanezt fordított irányban, de a leghosszabb sort nem kell megismételni, csak a többit.
*/

#include <stdio.h>

void printTriangle(int n) {
    for (int i = 1; i <= n; i++) {
        for (int j = 0; j < i; j++) {
            printf("#");
        }
        printf("\n");
    }

    for (int i = n - 1; i > 0; i--) {
        for (int j = 0; j < i; j++) {
            printf("#");
        }
        printf("\n");
    }
}

int main() {
    int num;
    scanf("%d", &num);

    printTriangle(num);

    return 0;
}