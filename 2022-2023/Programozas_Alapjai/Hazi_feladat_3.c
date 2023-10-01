/**
 * Az alábbi kód feladata bekérni egy háromszög három oldalának hosszát, és megvizsgálni,
 * hogy a megadott értékek helyesek-e. Egészítsd ki az alábbi kódot egy olyan összetett logikai kifejezéssel,
 * amely akkor igaz, ha a kapott három szám alkothat háromszöget!
 * Akkor létezik háromszög a három oldallal, ha mindhárom oldalra igaz, hogy rövidebb, mint a másik kettő összege.
*/

#include <stdio.h>

int main()
{
    int a, b, c;
    scanf("%d %d %d", &a, &b, &c);
    if (a+b > c && a+c >b && b+c > a)
        printf("JO\n");
    else
        printf("ROSSZ\n");
    return 0;
}

/**
 * Készíts egy C programot, amely bekér 3 egész számot, majd megjeleníti őket csökkenő sorrendben!
 * A kimeneten a számok egy sorban legyenek, szóközzel elválasztva.
*/

#include <stdio.h>

int main() {
    int a, b, c;
    scanf("%d", &a);
    scanf("%d", &b);
    scanf("%d", &c);
    
    if (a > b && a > c) {
        if (b > c) {
            printf("%d %d %d", a, b, c);
        }
        else
            printf("%d %d %d", a, c, b);
    }
    else if (b > a && b > c) {
        if (a > c)
            printf("%d %d %d", b, a, c);
        else
            printf("%d %d %d", b, c, a);
    }
    else {
        if ( b > a)
            printf("%d %d %d", c, b, a);
        else
            printf("%d %d %d", c, a, b);
    }
}

/**
 * Készíts egy programot C nyelven, amely bekér 4 egész számot, és megvizsgálja,
 * hogy szét bonthatóak-e kettő csoportra úgy, hogy a számok összege ugyanannyi mindkét csoportban!
 * A program kimenete "IGEN" vagy "NEM" legyen, az eredménynek megfelelően.
 * Figyelj arra, hogy a két csoportnak nem kell ugyanannyi számból állnia! Az is jó,
 * ha valamelyik két szám összege ugyanannyi, mint a másik kettő összege, de az is jó,
 * ha valamelyik szám önmagában ugyanannyi, mint a másik három összege.
*/

#include <stdio.h>

int main (){
    int a, b, c, d;
    scanf("%d %d %d %d", &a, &b, &c, &d);
    if ((a + b) == (c + d) || (a + c) == (b + d) || (a + d) == (b + c) || (a) == (b + c + d) || (b) == (a + c + d) || (c) == (a + b + d) || (d) == (a + c + b))
        printf("IGEN");
    else
        printf("NEM");
    return 0;
}

/**
 * Készíts egy C programot, amely képes egy számot kerekíteni egy másik szám többszörösére!
 * A program kérjen egy kettő egész számot, az első a kerekítendő érték, a másik a kerekítés alapja,
 * majd kerekítse az első számot a másik szám legközelebbi többszörösére. A program kimenete a kerekített érték legyen.
 * Például, ha a második szám 8, akkor az első számot 8 legközelebbi többszörösére kell kerekíteni.
 * Ilyen esetben a 0, 8, 16, 24, stb értékek nem változnak.
 * Az 5, 6, 7, 9, 10, 11 számokhoz a 8 van a legközelebb, a 13, 14, 15, 17, 18, 19 számokhoz a 16, stb.
 * Ha egy szám egyenlő távolságra van kettőtől lehetőségtől, akkor azt felfelé kell kerekíteni,
 * így pl. a 4-ből 8 lesz, a 12-ből 16, stb.
*/

#include<stdio.h>

int main()
{
    int a, b;
    int maradek, szorzo, eredmeny;
    scanf("%d", &a);
    scanf("%d", &b);
    maradek = a%b;
    if (maradek >= (b/2))
    {
        szorzo = (a/b+1);
        eredmeny = b*szorzo;
        printf("%d", eredmeny);
    }
    else 
    {
        szorzo = (a/b);
        eredmeny =b*szorzo;
        printf("%d", eredmeny);
    }
    
}