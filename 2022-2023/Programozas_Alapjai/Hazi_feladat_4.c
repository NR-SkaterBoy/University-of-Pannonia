/**
 * Készíts egy C programot, amely bekér egy időpontot (óra és perc).
 * Mivel helyes időpontot szeretnénk kapni, így az óra csak 0-23 között lehet,
 * a perc csak 0-59 között. Ha nem ilyen értéket írunk be, akkor kérd be újra az időpontot,
 * egész addig, amíg helyes nem lesz az adat (be kell kérni az órát és percet is, és csak utána vizsgálni).
 * A végén a program írja ki a két beolvasott értéket.
 */

#include <stdio.h>

int main()
{
    int ora, perc;
    do
    {
        scanf("%d %d", &ora, &perc);
    } while (ora < 0 || ora > 23 || perc < 0 || perc > 59);
    printf("%d %d", ora, perc);
    return 0;
}

/**
 * Az alábbi program bekéri egy négyzetrácsos pályán egy játékos jelenlegi helyzetét, valamint a célt, ahova el kell jutnia.
 * Egészítsd ki a programot, hogy megjelenítse a játékos mozgásait! A játékos a következő szabályok szerint mozog:
 * Először függőlegesen elmegy abba a sorba, ahol a cél van
 * Majd vízszintesen elmegy a célig
 * Mind a játékos, mind a cél esetében az első adat (jatekosX, celX) az x pozíciót adja meg, vagyis,
 * hogy vízszintesen hol van. Ez balról jobbra növekszik.
 * A második adat (jatekosY, celY) az y pozíciót, vagyis a sort tárolja. Ez lentről felfelé növekszik.
 * A játékos egyesével mozog. Minden mozgást egy külön sorba kell megjeleníteni a fel, le, jobbra, balra szövegek egyikével.
 */

#include <stdio.h>

int main()
{
    int jatekosX, jatekosY;
    int celX, celY;
    scanf("%d %d", &jatekosX, &jatekosY);
    scanf("%d %d", &celX, &celY);

    while (jatekosY != celY)
    {
        if (jatekosY < celY)
        {
            printf("fel\n");
            jatekosY++;
        }
        else
        {
            printf("le\n");
            jatekosY--;
        }
    }
    while (jatekosX != celX)
    {
        if (jatekosX < celX)
        {
            printf("jobbra\n");
            jatekosX++;
        }
        else
        {
            printf("balra\n");
            jatekosX--;
        }
    }
    return 0;
}