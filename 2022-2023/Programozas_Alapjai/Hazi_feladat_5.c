/**
 * Egészítsd ki az alábbi kódot a beker és kiir függvényekkel, amelyek rendre elvégzik egy egész szám bekérését
 * és kiírását úgy, hogy a main függvényben lévő kód működjön.
 */

#include <stdio.h>

static int beker()
{
    int b;
    scanf("%d", &b);
    return b;
}

static int kiir(int x)
{
    printf("ertek: %d\n", x);
}

int main()
{
    int a = beker();
    int b = beker();
    kiir(a);
    int c = beker();
    kiir(b);
    kiir(c);
    return 0;
}

/**
 * Egészítsd ki az alábbi kódot úgy, hogy az első rész kérje be a valt nevű struktúra változó adatait,
 * a második rész pedig írja ki azokat a minta szerint.
 */

#include <stdio.h>

struct datum
{
    int ev, honap, nap;
};

struct pozicio
{
    double szelessegiFok, hosszusagiFok;
};

struct erzekeles
{
    struct datum mikor;
    struct pozicio hol;
    int veszelyFaktor;
};

int main()
{
    struct erzekeles valt;

    // bekérés:

    scanf("%d", &valt.mikor.ev);
    scanf("%d", &valt.mikor.honap);
    scanf("%d", &valt.mikor.nap);

    scanf("%lf", &valt.hol.szelessegiFok);
    scanf("%lf", &valt.hol.hosszusagiFok);

    scanf("%d", &valt.veszelyFaktor);

    // kiírás:
    printf("KIIRAS:\n");

    printf("Mikor (ev, honap, nap): %d %d %d\n", valt.mikor.ev, valt.mikor.honap, valt.mikor.nap);
    printf("Hol (szelesseg, hosszusag): %lf %lf\n", valt.hol.szelessegiFok, valt.hol.hosszusagiFok);
    printf("Veszely faktor: %d", valt.veszelyFaktor);

    return 0;
}

/**
 * Egészítsd ki a kódot azzal a kettő struktúra definícióval, amellyel a kód megfelelően fog működni!
 */

#include <stdio.h>

struct pontok
{
    int azonosito;
    double pontszam;
};

struct adatok
{
    int ev, probalkozas;
    double pontszam, osszpont;

    struct pontok reszpont1;
    struct pontok reszpont2;
    struct pontok reszpont3;
};

int main()
{
    struct adatok a;
    scanf("%d", &a.ev);
    scanf("%d", &a.probalkozas);
    scanf("%d", &a.reszpont1.azonosito);
    scanf("%lf", &a.reszpont1.pontszam);
    scanf("%d", &a.reszpont2.azonosito);
    scanf("%lf", &a.reszpont2.pontszam);
    scanf("%d", &a.reszpont3.azonosito);
    scanf("%lf", &a.reszpont3.pontszam);

    a.osszpont = a.reszpont1.pontszam + a.reszpont2.pontszam + a.reszpont3.pontszam;

    printf("osszpont: %.2lf\n", a.osszpont);

    return 0;
}