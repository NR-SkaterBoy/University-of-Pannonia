/**
 * Beolvasás, kiírás, elágazások
*/

/**
 * Task 1
 * Adottak a következő változók:
 * Típus: dupla lebegőpontos, név: harom
 * Típus: dupla lebegőpontos, név: negyedik
 * Típus: előjeles egész, név: adat
 * Típus: előjeles egész, név: alma
 * Típus: egyszeres lebegőpontos, név: az
 * Típus: előjel nélküli egész, név: korte
 * Típus: dupla lebegőpontos, név: d
 */

scanf("%lf\n%lf\n%d\n%d\n%f\n%u\n%lf\n", &harom, &negyedik, &adat, &alma, &az, &korte, &d);

/**
 * Task 2
 * Adottak a következő változók:
 * Típus: előjeles egész, név: d
 * Típus: karakter, név: nev
 * Típus: előjel nélküli egész, név: tarol
 * Típus: dupla lebegőpontos, név: semmi
 * Típus: karakter, név: a
 * Típus: előjel nélküli egész, név: valami
 * Írd meg azt a kódot, amely kiírja a változók értékeit! (Csak a kiírás kell, a kód többi része nem.)
 * Minden változó külön sorban jelenjen meg. A lebegőpontos értéknél csak 2 tizedesjegy látszódjon.
 */

printf("%d\n", d);
printf("%c\n", nev);
printf("%u\n", tarol);
printf("%.2lf\n", semmi);
printf("%c\n", a);
printf("%u\n", valami);

/**
 * Task 3
 * Adottak a következő változók:
 * Típus: egyszeres lebegőpontos, név: ez
 * Típus: dupla lebegőpontos, név: harom
 * Típus: előjel nélküli egész, név: negyedik
 * Típus: egyszeres lebegőpontos, név: lol
 * Írd meg azt a kódot, amely beolvassa a változók értékeit! (Csak a beolvasás kell, a kód többi része nem.)
 */

scanf("%f %lf %u %f", &ez, &harom, &negyedik, &lol);

/**
 * Task 4
 * Adottak a következő változók:
 * Típus: dupla lebegőpontos, név: valami
 * Típus: előjeles egész, név: ketto
 * Típus: előjeles egész, név: alma
 * Típus: dupla lebegőpontos, név: d
 * Típus: dupla lebegőpontos, név: harom
 * Típus: karakter, név: ertek
 * Írd meg azt a kódot, amely kiírja a változók értékeit! (Csak a kiírás kell, a kód többi része nem.)
 * Minden változó külön sorban jelenjen meg. A lebegőpontos értéknél csak 2 tizedesjegy látszódjon.
 */

printf("%.2lf\n%d\n%d\n%.2lf\n%.2lf\n%c", valami, ketto, alma, d, harom, ertek);

/**
 * Task 5
 * Készíts egy C programot, amely bekér egy számjegyet
 * (egész szám, a bemenet csak 0-9 érték lesz), és megjeleníti a magyar szöveges megnevezését ékezetek nélkül.
 * (Ez elágazásos feladat, a printf magától nem tud ilyet.)
 */

#include <stdio.h>
int main()
{
    int a;
    scanf("%d", &a);

    if (a == 0)
        printf("nulla");
    else if (a == 1)
        printf("egy");
    else if (a == 2)
        printf("ketto");
    else if (a == 3)
        printf("harom");
    else if (a == 4)
        printf("negy");
    else if (a == 5)
        printf("ot");
    else if (a == 6)
        printf("hat");
    else if (a == 7)
        printf("het");
    else if (a == 8)
        printf("nyolc");
    else if (a == 9)
        printf("kilenc");

    return 0;
}

/**
 * Task 6
 * Egészítsd ki a megadott programot a megfelelő logikai kifejezéssel.
 * Akkor kell belépni az elágazásba, és végrehajtani az első printf-et, ha az a, b, c, d,
 * változók közül vagy az a, vagy a b a legnagyobb. Csak az abszolút legnagyobb esetet fogadjuk el, döntetlent nem.
 */

#include <stdio.h>

int main()
{
    int a, b, c, d;
    scanf("%d %d %d %d", &a, &b, &c, &d);
    if (
        (a > b && a > c && a > d) || (b > a && b > c && b > d))
    {
        printf("Az a vagy b az abszolut legnagyobb\n");
    }
    else
    {
        printf("Nem teljesul\n");
    }
    return 0;
}