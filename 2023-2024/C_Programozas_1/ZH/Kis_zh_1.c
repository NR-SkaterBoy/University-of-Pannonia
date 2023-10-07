/**
 * Készíts egy programot C nyelven, amely:
 * Bekér kettő egész és egy lebegőpontos számot
 * Kiírja a két egész szám összegét
 * Kiírja a lebegőpontos szám felét
 * Fontos
 * A lebegőpontos értékek két tizedesjegy pontossággal jelenjenek meg
 * Az egyes kiírások végén legyen sortörés, ahogy a minta kimeneten is látható
 * A kért adatokon kívül mást nem szabad megjeleníteni.
 */

#include <stdio.h>

int main()
{
    int a, b;
    float c;
    scanf("%d %d %f", &a, &b, &c);
    printf("%d\n", a + b);
    printf("%.2f\n", c / 2);
    return 0;
}

/**
 * Egészítsd ki a lentebbi programot az alábbiaknak megfelelően:
 * 1. A kicsi változót állítsd be az egyik és masik változók közül a kisebbre
 * 2. A kimeneten jelenjen meg a "KEVES", "SOK", vagy "PONT JO" szövegek egyike annak megfelelően,
 * hogy az a és b változók összege kisebb, mint 20, több mint 20, vagy pont 20.
 */

#include <stdio.h>

int main()
{
    double egyik, masik, kicsi;
    scanf("%lf %lf", &egyik, &masik);

    // 1. feladat megoldása
    if (egyik < masik)
        kicsi = egyik;
    else
        kicsi = masik;
    printf("%.2lf\n", kicsi);
    int a, b;
    scanf("%d %d", &a, &b);

    // 2. feladat megoldása
    if (a + b < 20)
        printf("KEVES");
    else if (a + b > 20)
        printf("SOK");
    else
        printf("PONT JO");
    return 0;
}

/**
 * Egészítsd ki a lenti kódot úgy, hogy listázza ki egymás alá az összes olyan pozitív egész számot,
 * amely osztója a szam változó értékének!
 */

#include <stdio.h>

int main()
{
    int szam;
    scanf("%d", &szam);
    for (int i = 1; i < szam + 1; i++) if (szam % i == 0) printf("%d\n", i);
    return 0;
}