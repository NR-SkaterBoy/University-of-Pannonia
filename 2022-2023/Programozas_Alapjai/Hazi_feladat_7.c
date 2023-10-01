/*

Az alábbi kód kiegészítésével valósítson meg egy adatelemző programot, mely bekéri meteorológiai állomások csapadékmérési adatait.

Legfeljebb 100 mérés eredményét kell kezelni. Az állomások azonosítószáma 1 és 10 között lehet. Az adatok az állomás száma mellett tárolják a dátumot (hónap és nap) valamint a mért csapadék mennyiségét mm-ben az alábbi példák szerint.

2-es szinthez írassa ki az összes bekért adatot az alábbi minták szerint!

3-as szinthez a program keresse meg hogy mikor és melyik állomáson volt a legnagyobb mennyiségű csapadékmérés!

4-es szinthez a program számolja ki egy bekért azonosítójú állomáson mért összes csapadékmennyiséget!

5-ös szinthez  a program határozza meg, hogy melyik állomáson mérték összesen a legtöbb csapadékmennyiséget!

Fontos:

A kimenetet program ellenőrzi, így karakterre pontosnak kell lennie (szóköz, sortörés, minden számít).
A megoldást lehetőleg külön fejlesztőkörnyezetben írja meg, az alapul adott kód kibővítésével, és csak akkor ellenőriztesse a Moodle-lel, ha már működik.
A Moodle a legvégén a legutolsó tesztelt kódot értékeli ki, így ha kész van egy adott szintig, akkor célszerű az ellenőrzéssel kiértékeltetni, és aztán kezdeni a következő szintet.
A megadott kódban csak a megjelölt függvényeket módosítsa, a többin ne változtasson! A mintakódot csak bővítse, ne töröljön belőle!
A kódnak általánosan kell működnie minden a leírásnak megfelelő bemenetre, nem csak a példában szereplőre! Az értékelés során több teszt fut, mint amit a példában látnak, ezért ha a program nem minden bemenetre működik, akkor kevesebb pontot is kaphat, mint a példa alapján tűnik. Ezért javasoljuk, hogy beküldés előtt többféle bemenetre is teszteljék!
A tesztre kapott pontszám adja meg a vizsgajegyet.

*/

#include <stdio.h>

#define ALLOMAS_MAX_SZAM 10

typedef struct
{
    unsigned int allomas, ho, nap, mm;
} Csapadek;

#define MERES_MAX_SZAM 100

typedef struct
{
    Csapadek meres[MERES_MAX_SZAM];
    unsigned int meresekSzama;
} Meresek;

Csapadek bekerCsapadek()
{
    Csapadek csapadek;
    // printf("..Adja meg az állomás számát (1-%d): ",ALLOMAS_MAX_SZAM);
    scanf("%d", &csapadek.allomas);
    // printf("..Adja meg a hónap sorszámát (1-12): ");
    scanf("%d", &csapadek.ho);
    // printf("..Adja meg a nap sorszámát (1-31): ");
    scanf("%d", &csapadek.nap);
    // printf("..Adja meg a napi csapadék mennyiségét mm-ben: ");
    scanf("%d", &csapadek.mm);
    return csapadek;
}

void kiirCsapadek(Csapadek csapadek)
{
    // Ezt meg kell írnia a 2-eshez!

    printf("..%d. állomáson %d.%d. %dmm\n",
           csapadek.allomas, csapadek.ho, csapadek.nap, csapadek.mm);
}

Meresek bekerMeresek()
{
    Meresek meresek;
    // printf("Kérem a mérések számát (1-100): ");
    scanf("%d", &meresek.meresekSzama);
    for (unsigned int i = 0; i < meresek.meresekSzama; i++)
    {
        // printf("Kérem a %d. mérés adatait:\n",i+1);
        meresek.meres[i] = bekerCsapadek();
    }
    return meresek;
}

void kiirMeresek(Meresek meresek)
{
    // Ezt meg kell írnia a 2-eshez!

    for (int i = 0; i < meresek.meresekSzama; i++)
    {
        printf("A %d. mérés adatai:\n", i + 1);
        kiirCsapadek(meresek.meres[i]);
    }
}

void kiirMax(Meresek meresek)
{
    // Ezt meg kell írnia a 3-ashoz!

    int max = 0;
    for (int i = 0; i < meresek.meresekSzama; i++)
    {
        if (meresek.meres[i].mm > meresek.meres[max].mm)
        {
            max = i;
        }
    }
    printf("A legnagyobb mért mennyiség:\n");
    kiirCsapadek(meresek.meres[max]);
}

unsigned int sum(Meresek meresek, unsigned int allomas)
{
    unsigned int osszeg = 0;
    // Ezt meg kell írnia a 4-eshez!

    for (int i = 0; i < meresek.meresekSzama; i++)
    {
        if (meresek.meres[i].allomas == allomas)
        {
            osszeg += meresek.meres[i].mm;
        }
    }

    return osszeg;
}

void kiirSum(Meresek meresek)
{
    unsigned int allomas;
    printf("Teljes mért mennyiség:\n");
    // printf("..Kérem az állomás számát (1-%d): ",ALLOMAS_MAX_SZAM);
    scanf("%d", &allomas);
    printf("..A mérések összege a %d. állomáson: %dmm\n", allomas, sum(meresek, allomas));
}

void kiirSumMax(Meresek meresek)
{
    // Ezt meg kell írnia a 5-öshöz!

    int allomasok[ALLOMAS_MAX_SZAM] = {0};
    for (int i = 0; i < ALLOMAS_MAX_SZAM; i++)
    {
        allomasok[i] = sum(meresek, i + 1);
    }
    int max = 0;
    for (int i = 1; i < ALLOMAS_MAX_SZAM; i++)
    {
        if (allomasok[i] > allomasok[max])
        {
            max = i;
        }
    }
    printf("A legtöbb csapadékot összesen a %d. állomáson mérték: %dmm-t.", max + 1, allomasok[max]);
}

int main(void)
{
    setbuf(stdout, NULL);
    int jegy;
    scanf("%d", &jegy);
    Meresek meresek;
    printf("Teszt az alábbi jegyért: %d\n", jegy);
    if (jegy >= 2)
        meresek = bekerMeresek();
    if (jegy >= 2)
        kiirMeresek(meresek);
    if (jegy >= 3)
        kiirMax(meresek);
    if (jegy >= 4)
        kiirSum(meresek);
    if (jegy >= 5)
        kiirSumMax(meresek);
    return 0;
}