/**
 * Készíts egy programot C nyelven, amely bekér 20 darab egész számot egy tömbbe,
 * és utána a minta szerinti módon megjeleníti a páros elemeket!
*/

#include <stdio.h>

int main() {
    int tomb[20];
    
    for (int i = 0; i < 20; i++){
        scanf("%d", &tomb[i]);
    }
    int a = 1;
    for (int i = 0; i < 20; i++){
        if (tomb[i] % 2 == 0){
            printf("%d. egesz szam: %d\n", a++, tomb[i]);
        }
    }
}

/**
 * Készíts egy programot C nyelven, amely bekér kettő darab 10 elemű, egész számokat tároló tömböt
 * (először az egyiket teljesen, majd a másikat)! Ezután a program írjon ki 10 sort, mindegyikben 2 számmal.
 * Az első számok a sorban az első tömb elemei legyenek sorrendben, a második számok pedig a második tömb elemei fordított sorrendben.
*/

#include <stdio.h>

int main(){
    int arr[10]; int arr2[10];
    for (int i = 0; i < 10; i++)
        scanf("%d", &arr[i]);
    for (int i = 0; i < 10; i++)
        scanf("%d", &arr2[i]);
    
    int crnt[10];
    for (int i = 0; i < 10; i++){
        for (int j = 0; j < 10; j++)
            crnt[j] = arr2[j];
        printf("%d %d\n", arr[i], crnt[9 -i]);
    }
}