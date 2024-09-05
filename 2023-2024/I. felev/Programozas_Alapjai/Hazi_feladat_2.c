/**
 * Egészítsd ki az alábbi kódot úgy, hogy a mintában megadott kimenetet adja!
 * Minden mezőbe csak egy sor kód mehet, de lesz olyan mező, amelyik üresen marad.
 */

#include <stdio.h>

void fejlesztes()
{
    printf("Fejlesztes eleje\n");
    printf("Adatszerkezet megvalositasa\n");
    printf("Fuggvenyek elkeszitese\n");
    printf("Algoritmusok implementalasa\n");
    printf("Felhasznaloi interfesz elkeszitese\n");
    printf("Dokumentacio megirasa\n");
    printf("Fejlesztes vege\n");
}

void teszteles()
{
    printf("Teszteles eleje\n");
    printf("Funkciok tesztelese\n");
    printf("Erthetoseg vizsgalata\n");
    printf("Hibak javitasa\n");
    printf("Teszteles vege\n");
}

void tervezes()
{
    printf("Tervezes eleje\n");
    printf("Kovetelmenyek meghatarozasa\n");
    printf("Adatszerkezet megtervezese\n");
    printf("Tervezes vege\n");
}

int main()
{
    tervezes();
    fejlesztes();
    teszteles();
    return 0;
}

/**
 * Egészítsd ki az alábbi kódot! A különálló eljárásokat kell a main-ben meghívni,
 * hogy a program a megfelelő kimenetet adja az adott bemenetre.
 */

#include <stdio.h>

int x;
int y;

void bekeres1()
{
    printf("Kerem az x erteket: \n");
    scanf("%d", &x);
}

void bekeres2()
{
    printf("Kerem megint az x erteket: \n");
    scanf("%d", &x);
}

void szamolas1()
{
    y = x * 10;
}

void szamolas2()
{
    x += 5;
}

void kiiras1()
{
    printf("Az x erteke: %d\n", x);
}

void kiiras2()
{
    printf("Az y erteke: %d\n", y);
}

int main()
{
    bekeres1();
    kiiras1();
    szamolas1();
    kiiras2();
    szamolas2();
    kiiras1();
    szamolas1();
    kiiras2();
    bekeres2();
    kiiras1();
    kiiras2();
    szamolas2();
    szamolas1();
    kiiras1();
    kiiras2();
    return 0;
}

/**
 * Egy olyan eljárást szeretnénk készíteni, amely egy lakás teljes alapterületét számolja ki.
 * A lakásban három szoba van. Az eljárás mindegyiknek bekéri a szélességét és a hosszúságát,
 * és a végén kiírja az össz területet.
 * A lentebbi pszeudo kódok mindegyike ezt az eljárást írja le, azonban az egyik hibás. Melyik az?
*/

/*

Eljárás összterületSzámítás()
    Bekér elsőSzélesség
    Bekér elsőHosszúság
    Bekér másodikSzélesség
    Bekér másodikHosszúság
    elsőTerület = elsőSzélesség * elsőHosszúság
    harmadikTerület = harmadikSzélesség * harmadikHosszúság
    Bekér harmadikSzélesség
    Bekér harmadikHosszúság
    másodikTerület = másodikSzélesség * másodikHosszúság
    teljesTerület = elsőTerület + másodikTerület + harmadikTerület
    Kiír teljesTerület
Eljárás vége

*/