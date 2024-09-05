#include <stdio.h>

void feladat1()
{
    int szam = 0;
    do
    {
        printf("Kerem a szamot: ");
        scanf("%d", &szam);
        printf("A bekert szam: %d\n", szam);
    } while (szam < 100);
}

void feladat2()
{
    double lebego[5];
    for (int i = 0; i < 5; i++)
    {
        printf("Kerem a(z) %d szamot: ", i + 1);
        scanf("%lf", &lebego[i]);
        printf("A(z) %d szam duplaja: %.2lf\n", i + 1, lebego[i] * 2);
    }
}

void feladat3()
{
    double szamok[10];
    int db = 0;
    for (int i = 0; i < 10; i++)
    {
        scanf("%lf", &szamok[i]);
    }

    for (int i = 0; i < 10; i++)
    {
        if (szamok[i] > 0)
            db++;
    }
    printf("%d\n", db);
}

void feladat4()
{
    int bekeres, paros = 0;
    do
    {
        scanf("%d", &bekeres);
        if (bekeres % 2 == 0 && bekeres != 0)
            paros++;
    } while (bekeres >= 1);
    printf("Osszesen %d paros szam van a bekert szamok kozott.", paros);
}

void feladat5()
{
    int beker, cnt = 0, db = 0;
    scanf("%d", &beker);
    cnt = beker + 1;
    while (cnt > beker)
    {
        cnt = beker;
        db++;
        scanf("%d", &beker);
    }
    printf("%d", db);
}

void feladat6()
{
    int szel, mag;
    printf("Add meg a szelesseget: ");
    scanf("%d", &szel);
    printf("Add meg a magassagot: ");
    scanf("%d", &mag);
    for (int i = 0; i < szel; i++)
    {
        for (int j = 0; j < mag; j++)
        {
            printf("#");
        }
        printf("\n");
    }
}

void feladat7()
{
    int szelesseg, magassag;
    printf("Add meg a szelesseget: ");
    scanf("%d", &szelesseg);
    printf("Add meg a magassagot: ");
    scanf("%d", &magassag);
    for (int i = 0; i < szelesseg; i++) printf("#");
    printf("\n");

    for (int i = 0; i < magassag - 2; i++)
    {
        printf("#");
        for (int j = 0; j < szelesseg - 2; j++) printf(" ");
        printf("#\n");
    }

    for (int i = 0; i < szelesseg; i++) printf("#");
    printf("\n");
}

int main()
{
    feladat1();
    feladat2();
    feladat3();
    feladat4();
    feladat5();
    feladat6();
    feladat7();
}