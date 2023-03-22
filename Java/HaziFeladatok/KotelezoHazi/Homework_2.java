/**
 * Készítse el a Szamok osztályt kettő egész adattaggal (ertek és darab), valamint a megfelelő metódusokkal,
 * hogy a példában megjelölt kód működjön.
 * Konstruktor: paraméterben megkap két egész értéket és beállítja az adattagokat.
 * A konstruktort lehessen paraméter nélkül is meghívni, ekkor a változók értékei 2118 és 3167 legyenek.
 * getErtek metódus: visszaadja az ertek adattag értékét.
 * getDarab metódus: visszaadja a darab adattag értékét.
 * nagyobb metódus: visszaadja a kettő adattag közül a nagyobbat
 */


// Alapkód

import java.util.Scanner;

/*##SOLUTION##*/
// Ide kerul a valasz!
/*##SOLUTION##*/

public class __tester__ {

    public static void main(String[] args) {
        int x1, x2;
        Scanner input = new Scanner(System.in);
        x1 = input.nextInt();
        x2 = input.nextInt();
        Szamok elso = new Szamok(x1, x2);
        System.out.println(elso.getErtek());
        System.out.println(elso.getDarab());
        System.out.println(elso.nagyobb());
        Szamok masodik = new Szamok();
        System.out.println(masodik.getErtek());
        System.out.println(masodik.getDarab());
        System.out.println(masodik.nagyobb());
    }
}


// Megoldás

public class Szamok {
    private int ertek, darab;
    
    public Szamok(int ertek, int darab) {
        this.ertek = ertek;
        this.darab = darab;
    }
    
    public Szamok() {
        this.ertek = 2118;
        this.darab = 3167;
    }
    
    public int getErtek() {
        return this.ertek;
    }
    
    public int getDarab() {
        return this.darab;
    }
    
    public int nagyobb() {
        if (this.ertek > this.darab) return this.ertek;
        else return this.darab;
    }
    
}