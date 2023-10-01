/**
 * Programozási tételek
 */

/**
 * Task 1
 * Egészítsd ki az alábbi programot úgy, hogy cserélje meg var1 és var2 változók értékét.
 */

#include <stdio.h>

int main()
{
    int var1;
    int var2;
    scanf("%d %d", &var1, &var2);

    int c = var1;
    var1 = var2;
    var2 = c;

    printf("%d %d", var1, var2);
    return 0;
}

/**
 * Task 2
 * Egészítsd ki az alábbi kódot úgy, hogy számolja meg és írja ki,
 * hogy a tömbben (sokadat) mennyi olyan érték van, amelyik nagyobb a külön bekért számnál (korte).
 */

#include <stdio.h>

int main()
{
    int sokadat[10];
    int i;
    for (i = 0; i < 10; i++)
        scanf("%d", &sokadat[i]);
    int korte;
    scanf("%d", &korte);

    int a = 0;
    for (int i = 0; i < 10; i++)
    {
        if (korte < sokadat[i])
            a++;
    }

    printf("%d", a);

    return 0;
}

/**
 * Task 3
 * Egészítsd ki az alábbi kódot úgy, hogy keresse meg a tömbben (sokelem) az első olyan értéket,
 * amelyik osztható a bekért számmal (ertek). A kimeneten az első találat indexe jelenjen meg,
 * valamint vele egy sorban az értéke is, a minta szerinti formátumban. Ha egyik elem sem osztható a
 * bekért számmal, akkor a kimenet "NINCS" legyen.
 */

#include <stdio.h>

int main()
{
    int sokelem[12];
    int i;
    for (i = 0; i < 12; i++)
        scanf("%d", &sokelem[i]);
    int ertek;
    scanf("%d", &ertek);

    int idx = 0, a = 0;

    while (sokelem[a] % ertek != 0)
    {
        a++;
        idx++;
    }

    if (idx == 12)
        printf("NINCS");
    else
        printf("index: %d, ertek: %d", idx, sokelem[idx]);

    return 0;
}

/**
 * Task 4
 * Egészítsd ki az alábbi kódot úgy, hogy keresse meg a tömb (sokadat) legnagyobb elemét.
 * A kimeneten a legnagyobb érték indexe jelenjen meg, valamint vele egy sorban az értéke is,
 * a minta szerinti formátumban. Ha az érték többször is szerepel, akkor a legkisebb indexet kell megjeleníteni.
 */

#include <stdio.h>

int main()
{
    int sokadat[15];
    int i;
    for (i = 0; i < 15; i++)
        scanf("%d", &sokadat[i]);

    int max_idx = 0;
    for (i = 1; i < 15; i++)
    {
        if (sokadat[i] > sokadat[max_idx])
            max_idx = i;
    }
    printf("index: %d, ertek: %d\n", max_idx, sokadat[max_idx]);

    return 0;
}

/**
 * Task 5
 * Egészítsd ki az alábbi kódot úgy, hogy rendezze a tömb (valtozok) elemeit csökkenő sorrendbe.
 * A megoldásban a kód elején lévő MERET szimbólumot kell használni, mert minden teszt esetnél más lesz a tömb mérete.
 */

#include <stdio.h>

#define MERET 8

int main()
{
    double valtozok[MERET];
    int i;
    for (i = 0; i < MERET; i++)
        scanf("%lf", &valtozok[i]);

    for (int i = 0; i < MERET; i++)
    {
        for (int j = i + 1; j < MERET; j++)
        {
            if (valtozok[i] < valtozok[j])
            {
                double csere = valtozok[i];
                valtozok[i] = valtozok[j];
                valtozok[j] = csere;
            }
        }
    }

    for (i = 0; i < MERET; i++)
        printf("%.2lf\n", valtozok[i]);

    return 0;
}

/**
 * Task 6
 * Egészítsd ki az alábbi programot úgy, hogy a program végén a kiírásban mindig a kisebb érték jelenjen meg először.
 */

#include <stdio.h>

int main()
{
    int egyik;
    int b;
    scanf("%d %d", &egyik, &b);

    int a;
    if (b < egyik)
    {
        a = b;
        b = egyik;
        egyik = a;
    }

    printf("%d %d", egyik, b);
    return 0;
}

/**
 * Task 7
 * Készíts egy programot C nyelven, amely létrehoz kettő darab 10 elemű tömböt (egész számok tárolására),
 * és bekéri az elemeiket (először az egyik tömb, aztán a másik).
 * Majd ezután írassa ki, hogy melyek azok az elemek, amelyek az első tömbben többször szerepelnek, mint a másodikban.
 * Azt tudjuk, hogy a tömbök elemei csak 0 és 99 között lehetnek (célszerű ezt ki is használni a megoldásban).
 * A kimeneten a megfelelő értékek mind külön sorban jelenjenek meg, növekvő sorrendben.
 */

#include <stdio.h>
int main()
{
    int i, j;
    int egy, ketto;

    int elso[10];
    int masodik[10];
    for (i = 0; i < 10; i++)
    {
        scanf("%d", &elso[i]);
    }
    for (i = 0; i < 10; i++)
    {
        scanf("%d", &masodik[i]);
    }
    for (i = 0; i < 100; i++)
    {
        egy = 0;
        ketto = 0;
        for (j = 0; j < 10; j++)
        {
            if (i == elso[j])
            {
                egy++;
            }
            if (i == masodik[j])
            {
                ketto++;
            }
        }
        if (egy > ketto)
        {
            printf("%d\n", i);
        }
    }
}

/**
 * Task 8
 * Készíts egy programot C nyelven, amely létrehoz kettő darab 8 elemű tömböt (egész számok tárolására),
 * és bekéri az elemeiket (először az egyik tömb, aztán a másik). Ezután kérjen be még egy egész számot.
 * A program írassa ki, hogy melyik tömbben fordul elő a szám hamarabb (kisebb indexen, csak az első előfordulások érdekesek).
 * A kimeneten kettő szám legyen: az első 1 vagy 2, annak megfelelően, hogy az első, vagy második tömbben szerepel korábban a
 * szám; a másik pedig a szám indexe ebben a tömbben. Ha a szám egyik tömbben sem található meg egyszer sem, akkor a kimenet
 * "NINCS" legyen. Ha mindkét tömbben ugyanazon az indexen van az első előfordulás, akkor a kimeneten "EGYENLO" jelenjen meg,
 * majd utána az index. (Értelemszerűen, ha a szám csak az egyik tömbben szerepel a kettő közül, akkor az a tömb lesz a megoldás.)
 */

#include <stdio.h>
#include <stdbool.h>

#define L 8

int main()
{
    int idx1 = 0, idx2 = 0, bekerSzam;
    int tomb1[8];
    int tomb2[8];

    bool l = false;
    bool k = false;

    for (int i = 0; i < L; i++)
    {
        scanf("%d", &tomb1[i]);
    }

    for (int i = 0; i < L; i++)
    {
        scanf("%d", &tomb2[i]);
    }

    scanf("%d", &bekerSzam);

    for (int i = 0; i < L; i++)
    {
        if (bekerSzam == tomb1[i])
        {
            idx1 = i;
            l = true;
            break;
        }
    }

    for (int i = 0; i < L; i++)
    {
        if (bekerSzam == tomb2[i])
        {
            idx2 = i;
            k = true;
            break;
        }
    }

    if (idx1 < idx2 && l)
        printf("%d %d", 1, idx1);
    else if (idx2 < idx1 && k)
        printf("%d %d", 2, idx2);
    else if (idx1 == 0 && idx2 == 0)
        printf("NINCS");
    else if (idx1 == idx2)
        printf("EGYENLO %d", idx2);
    else if (!l && k)
        printf("%d %d", 2, idx2);
}

/**
 * Task 9
 * Készíts egy programot C nyelven, amely létrehoz kettő darab 10 elemű tömböt
 * (egész számok tárolására), és bekéri az elemeiket (először az egyik tömb, aztán a másik).
 * A program keresse meg mindkét tömb legkisebb elemét, és mondja meg, hogy ez az érték melyik tömbben a nagyobb,
 * valamint jelenjen meg maga a szám is. A kimenet kettő sor legyen. Az elsőben "ELSO", "MASODIK", vagy "EGYENLO"
 * jelenjen meg, attól függően, hogy a legkisebb érték az első vagy a második tömbben a nagyobb, vagy egyenlő a kettőben.
 * A második sor maga az érték legyen (a két legkisebb közül a nagyobb).
 */

#include <stdio.h>

#define L 10

int main()
{
    int minIdx1 = 0, minIdx2 = 0;
    int tomb1[10], tomb2[10];

    for (int i = 0; i < L; i++)
    {
        scanf("%d", &tomb1[i]);
    }

    for (int i = 0; i < L; i++)
    {
        scanf("%d", &tomb2[i]);
    }

    for (int i = 0; i < L; i++)
    {
        if (tomb1[i] < tomb1[minIdx1])
            minIdx1 = i;
    }

    for (int i = 0; i < L; i++)
    {
        if (tomb2[i] < tomb2[minIdx2])
            minIdx2 = i;
    }

    if (tomb1[minIdx1] == tomb2[minIdx2])
        printf("EGYENLO\n%d", tomb1[minIdx1]);
    else if (tomb1[minIdx1] > tomb2[minIdx2])
        printf("ELSO\n%d", tomb1[minIdx1]);
    else if (tomb1[minIdx1] < tomb2[minIdx2])
        printf("MASODIK\n%d", tomb2[minIdx2]);

    // printf("%d %d", tomb1[minIdx1], tomb2[minIdx2]);
}

/**
 * Task 10
 * Készíts egy programot C nyelven, amely létrehoz egy 10 elemű, egész számokat tartalmazó tömböt,
 * és bekéri az elemeit! A program rendezze a tömböt a számok abszolút értéke szerint növekvő sorrendbe,
 * majd jelenítse meg a rendezett tömböt (minden számot külön sorba)! (Nem lesz olyan bemenet, ahol több
 * számnak is ugyanaz az abszolút értéke, így ezzel az esettel nem kell külön foglalkozni.)
 */

#include <stdio.h>

int main()
{
    int tomb[10];
    int i, j, temp, x, y;
    for (i = 0; i < 10; i++)
        scanf("%d", &tomb[i]);
    for (i = 0; i < 9; i++)
    {
        for (j = i + 1; j < 10; j++)
        {
            if (tomb[i] < 0)
            {
                x = tomb[i] * (-1);
            }
            else
            {
                x = tomb[i];
            }
            if (tomb[j] < 0)
            {
                y = tomb[j] * (-1);
            }
            else
            {
                y = tomb[j];
            }
            if (x > y)
            {
                temp = tomb[i];
                tomb[i] = tomb[j];
                tomb[j] = temp;
            }
        }
    }
    for (i = 0; i < 10; i++) printf("%d\n", tomb[i]);

    return 0;
}