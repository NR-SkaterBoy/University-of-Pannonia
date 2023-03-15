/*
 * Készítse el a Valami osztályt a megfelelő metódusokkal, hogy a példában megjelölt kód működjön.
 * ujszam metódus: bekér és visszaad egy egész értéket.
 * beallit metódus: a paraméterben kapott egész értéket elmenti az objektumban.
 * mutat metódus: megjeleníti a tárolt értéket, a látható szöveg kíséretében (a kimenetre figyelni kell, minden karakter számít).
*/

// Alapkód:

import java.util.Scanner;

/*##SOLUTION##*/
// Ide kerul a valasz!
/*##SOLUTION##*/

public class __tester__ {

    public static void main(String[] args) {
        Valami var= new Valami();
        int i=var.ujszam();
        System.out.println(i);
        i=49;
        var.beallit(i);
        var.mutat();
    }
}

// Megoldás

public class Valami {
    private int szam;

    public int ujszam() {
        Scanner scanner = new Scanner(System.in);
        szam = scanner.nextInt();
        return szam;
    }

    public void beallit(int ujSzam) {
        szam = ujSzam;
    }

    public void mutat() {
        System.out.println("Kimenet : " + szam);
    }
}
