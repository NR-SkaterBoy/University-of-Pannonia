/**
 * Egészítsd ki a megadott programot a megfelelő logikai kifejezéssel. Akkor kell belépni az elágazásba,
 * és végrehajtani az első printf-et, ha az a, b, c, d, változók közül vagy az a, vagy a b a legnagyobb.
 * Csak az abszolút legnagyobb esetet fogadjuk el, döntetlent nem.
*/

#include <stdio.h>

int main()
{
    int a, b, c, d;
    scanf("%d %d %d %d", &a, &b, &c, &d);
    if ( (a > b && a > c && a > d) || (b > a && b > c && b > d))
        printf("Az a vagy b az abszolut legnagyobb\n");
    else
        printf("Nem teljesul\n");
    return 0;
}

/**
 * Készíts egy C programot, amely bekér egy számjegyet (egész szám, a bemenet csak 0-9 érték lesz),
 * és megjeleníti a magyar szöveges megnevezését ékezetek nélkül.
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
