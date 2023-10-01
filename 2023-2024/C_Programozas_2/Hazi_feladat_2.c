/**
 * Egészítsd ki az alábbi kódot úgy, hogy:
 * az x változó értékének állítsd be az a változó kétszeresét
 * az y változó értéke legyen a b és a c változók különbsége (b-ből kivonva a c-t)
 * a z változó értéke legyen az x és az y változók összege
 */

#include <stdio.h>

int main()
{
    int a, b, c, x, y, z;
    scanf("%d %d %d", &a, &b, &c);

    x = 2 * a;
    y = b - c;
    z = x + y;

    printf("%d %d %d\n", x, y, z);
    return 0;
}

/**
 * Egészítsd ki az alábbi kódot úgy, hogy:
 * az x változó értékének állítsd be az b változó felét
 * az y változó értéke legyen a c változó háromszorosának és a b változó ötszörösének az összege
 * a z változó értékének állítsd be az y változó és az a változó hányadosát (y osztva a-val)
 */

#include <stdio.h>

int main()
{
    double a, b, c, x, y, z;
    scanf("%lf %lf %lf", &a, &b, &c);

    x = b / 2;
    y = (c * 3) + (b * 5);
    z = y / a;

    printf("%.2lf %.2lf %.2lf\n", x, y, z);
    return 0;
}

/**
 * Egészítsd ki az alábbi kódot úgy, hogy:
 * az x változó értéke legyen az a változó osztási maradéka 3-mal
 * az y változó értéke legyen a b és a c változók hányadosa (b osztva c-vel)
 * a z változó értéke legyen a b változó osztási maradéka a c változóval
 */

#include <stdio.h>

int main()
{
    int a, b, c, x, y, z;
    scanf("%d %d %d", &a, &b, &c);

    x = a % 3;
    y = b / c;
    z = b % c;

    printf("%d %d %d\n", x, y, z);
    return 0;
}

/**
 * Adottak a következő változók:
 * Típus: karakter, név: semmi
 * Típus: előjel nélküli egész, név: az
 * Típus: előjeles egész, név: harom
 * Típus: egyszeres lebegőpontos, név: lol
 * Típus: karakter, név: xd
 * Típus: karakter, név: adat
 * Írd meg azt a kódot, amely beolvassa a változók értékeit! (Csak a beolvasás kell, a kód többi része nem.)
*/

scanf("%c %u %d %f %c %c", &semmi, &az, &harom, &lol, &xd, &adat);

/**
 * Adottak a következő változók:
 * Típus: előjeles egész, név: c
 * Típus: előjel nélküli egész, név: alma
 * Típus: karakter, név: xd
 * Típus: előjel nélküli egész, név: valtozo
 * Típus: előjeles egész, név: harmadik
 * Típus: előjel nélküli egész, név: korte
 * Típus: dupla lebegőpontos, név: temp
 * Típus: előjeles egész, név: z
 * Írd meg azt a kódot, amely beolvassa a változók értékeit! (Csak a beolvasás kell, a kód többi része nem.)
*/

scanf("%d %u %c %u %d %u %lf %d", &c, &alma, &xd, &valtozo, &harmadik, &korte, &temp, &z);

/**
 * Adottak a következő változók:
 * Típus: előjel nélküli egész, név: b
 * Típus: előjel nélküli egész, név: egy
 * Típus: egyszeres lebegőpontos, név: adat
 * Típus: karakter, név: c
 * Típus: előjel nélküli egész, név: harmadik
 * Típus: karakter, név: korte
 * Típus: előjel nélküli egész, név: y
 * Írd meg azt a kódot, amely kiírja a változók értékeit! (Csak a kiírás kell, a kód többi része nem.)
 * Minden változó külön sorban jelenjen meg. A lebegőpontos értéknél csak 2 tizedesjegy látszódjon.
*/

printf("%u\n%u\n%.2f\n%c\n%u\n%c\n%u", b,egy,adat,c,harmadik,korte,y);

/**
 * Adottak a következő változók:
 * Típus: egyszeres lebegőpontos, név: egy
 * Típus: előjel nélküli egész, név: b
 * Típus: előjel nélküli egész, név: xd
 * Típus: dupla lebegőpontos, név: harmadik
 * Írd meg azt a kódot, amely kiírja a változók értékeit! (Csak a kiírás kell, a kód többi része nem.)
 * Minden változó külön sorban jelenjen meg. A lebegőpontos értéknél csak 2 tizedesjegy látszódjon
*/

printf("%.2f\n%u\n%u\n%.2lf",egy, b, xd, harmadik);

/**
 * Hozz létre kettő előjeles egész változót egy és ketto néven,
 * valamint két előjel nélküli egész változót harom és negy néven.
 * (Csak a változó létrehozás kell, a kód többi része nem.)
*/

int egy, ketto;
unsigned harom, negy;

/**
 * Hozz létre egy egyszeres pontosságú lebegőpontos változót lebego néven,
 * egy dupla pontosságú lebegőpontos egész változót dupla néven,
 * valamint egy karakter típusú változót karakter néven.
 * (Csak a változó létrehozás kell, a kód többi része nem.)
*/

float lebego;
double dupla;
char karakter;

/**
 * Hozz létre egy előjeles egész változót egesz néven, aminek a kezdeti értéke legyen -65.
 * Hozz létre egy dupla pontosságú lebegőpontos egész változót masik néven, aminek a kezdeti értéke legyen 634.4.
 * Hozz létre egy karakter típusú változót karakter néven, aminek a kezdeti értéke legyen 'c'.
*/

int egesz = -65;
double masik = 634.4;
char karakter = 'c';

/**
 * Hozd létre a következő változókat a megadott névvel és típussal, illetve kezdeti értékkel, ahol az is kell:
 * Típus: előjeles egész, név: adat, kezdeti érték: nincs
 * Típus: egyszeres lebegőpontos, név: x, kezdeti érték: 0.32
 * (Csak a változó létrehozás kell, a kód többi része nem.)
*/

int adat;
float x = 0.32;

/**
 * Hozd létre a következő változókat a megadott névvel és típussal, illetve kezdeti értékkel, ahol az is kell:
 * Típus: előjeles egész, név: x, kezdeti érték: nincs
 * Típus: előjel nélküli egész, név: z, kezdeti érték: 1085
 * Típus: dupla lebegőpontos, név: alma, kezdeti érték: 9.15
 * Típus: egyszeres lebegőpontos, név: korte, kezdeti érték: nincs
 * Típus: egyszeres lebegőpontos, név: d, kezdeti érték: -4.43
 * (Csak a változó létrehozás kell, a kód többi része nem.)
*/

int x;
unsigned z = 1085;
double alma = 9.15;
float korte, d = -4.43;