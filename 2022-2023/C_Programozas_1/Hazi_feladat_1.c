/**
 * Bevezetés, változók
*/

/**
 * Task 1
 * Hozz létre kettő előjeles egész változót egy és ketto néven,
 * valamint két előjel nélküli egész változót harom és negy néven.
 * (Csak a változó létrehozás kell, a kód többi része nem.)
 */

int egy;
int ketto;
unsigned harom;
unsigned negy;

/**
 * Task 2
 * Hozz létre egy egyszeres pontosságú lebegőpontos változót lebego néven,
 * egy dupla pontosságú lebegőpontos egész változót dupla néven, valamint egy
 * karakter típusú változót karakter néven. (Csak a változó létrehozás kell, a kód többi része nem.)
 */

float lebego;
double dupla;
char karakter;

/**
 * Task 3
 * Hozz létre egy előjeles egész változót egesz néven, aminek a kezdeti értéke legyen -65
 * Hozz létre egy dupla pontosságú lebegőpontos egész változót masik néven, aminek a kezdeti értéke legyen 634.4.
 * Hozz létre egy karakter típusú változót karakter néven, aminek a kezdeti értéke legyen 'c'.
 */

int egesz = -65;
double masik = 634.4;
char karakter = 'c';

/**
 * Task 4
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
 * Task 5
 * Egészítsd ki az alábbi kódot úgy, hogy:
 * az x változó értékének állítsd be az b változó felét
 * az y változó értéke legyen a c változó háromszorosának és a b változó ötszörösének az összege
 * az y változó értéke legyen a c változó háromszorosának és a b változó ötszörösének az összege
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
 * Task 6
 * Egészítsd ki az alábbi kódot úgy, hogy:
 * Egészítsd ki az alábbi kódot úgy, hogy:
 * az y változó értéke legyen a b és a c változók hányadosa (b osztva c-vel)
 * az y változó értéke legyen a b és a c változók hányadosa (b osztva c-vel)
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
 * Task 7
 * Hozd létre a következő változókat a megadott névvel és típussal, illetve kezdeti értékkel, ahol az is kell:
 * Típus: dupla lebegőpontos, név: y, kezdeti érték: nincs
 * Típus: dupla lebegőpontos, név: y, kezdeti érték: nincs
 * Típus: előjeles egész, név: xd, kezdeti érték: nincs
*/

double y;
float masik = 0.45;
int xd;


/**
 * Task 8
 * Hozd létre a következő változókat a megadott névvel és típussal, illetve kezdeti értékkel, ahol az is kell:
 * Típus: egyszeres lebegőpontos, név: temp, kezdeti érték: -1.84
 * Típus: egyszeres lebegőpontos, név: temp, kezdeti érték: -1.84
 * Típus: dupla lebegőpontos, név: egy, kezdeti érték: nincs
 * Típus: dupla lebegőpontos, név: egy, kezdeti érték: nincs
*/

float temp = -1.84;
unsigned d = 1501;
double egy;
int tarol;