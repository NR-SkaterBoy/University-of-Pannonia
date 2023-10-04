#include <stdio.h>

void feladat3() {
    float szamok [10];
    int db = 0;
    for (int i = 0; i < 10; i++)
    {
        scanf("%f", &szamok[i]);    
    }
    
    for (int i = 0; i < 10; i++)
    {
        if (szamok[i] > 0) db++;
    }
    printf("%d\n", db);
}

void feladat4() {
    int db = 0, szamok = 0;
    scanf("%d", &szamok);
    while (szamok == 0 || szamok < 0)
    {
        scanf("%d", &szamok);
        db++;
    }
    printf("%d\n", db);    
}


int main() {
    feladat3();
    feladat4();
}