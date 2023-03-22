/**
 * A megadott kód tartalmaz egy Kocsi osztályt, a következő adattagokkal:
 * --- gyártó (gyarto)
 * --- vételár (vetelar)
 * --- évjárat (evjarat)
 * Az adattagokhoz van getter, a beállításukat a konstruktor végzi.
 * Készítsd el a(z) Tarolo osztályt, amely dinamikusan létrehozott Kocsi
 * objektumok tömbjét tárolja (a tömb fix méretű, referenciákat tárol). A
 * feladat a tároló osztály elkészítése az alábbiaknak megfelelő konstruktorral
 * és metódusokkal:
 * --- konstruktor: paraméterben várja a tömb méretét, és lefoglalja azt.
 * --- ujkocsi metódus: paraméterben egy Kocsi referenciát és egy indexet vár. A
 * függvény a tömb adott indexű elemét állítja be (feltételezhetjük hogy az
 * index helyes, és a példakód minden indexet pontosan egyszer állít be).
 * --- mennyiUjabb metódus: megszámolja és visszaadja azon Kocsi objektumok
 * darabszámát, amelyekben az évjárat adattag értéke nagyobb, mint a
 * paraméterben kapott érték.
 * --- kevesebbMint metódus: megjeleníti az összes olyan Kocsi objektumot (a
 * kimeneti minta szerint), amelyekben a vételár adattag értéke kisebb, mint a
 * paraméterben kapott érték.
 */

// Alapkód
class Kocsi {
    private String gyarto;
    private int vetelar;
    private int evjarat;

    public Kocsi(String _gyarto, int _vetelar, int _evjarat) {
        this.gyarto = _gyarto;
        this.vetelar = _vetelar;
        this.evjarat = _evjarat;
    }

    public String getGyarto() {
        return gyarto;
    }

    public int getVetelar() {
        return vetelar;
    }

    public int getEvjarat() {
        return evjarat;
    }

}

/* ##SOLUTION## */
// Ide kerul a valasz!
/* ##SOLUTION## */

public class __tester__ {

    public static void main(String[] args) {
        Tarolo autotar = new Tarolo(11);

        autotar.ujkocsi(new Kocsi("Seat", 9159167, 1982), 0);
        autotar.ujkocsi(new Kocsi("Audi", 20114659, 1985), 1);
        autotar.ujkocsi(new Kocsi("Ford", 7159622, 1994), 2);
        autotar.ujkocsi(new Kocsi("Fiat", 25095155, 2000), 3);
        autotar.ujkocsi(new Kocsi("Ford", 28501672, 1995), 4);
        autotar.ujkocsi(new Kocsi("Seat", 25195217, 2016), 5);
        autotar.ujkocsi(new Kocsi("Skoda", 3442246, 1982), 6);
        autotar.ujkocsi(new Kocsi("Mercedes", 16137837, 2006), 7);
        autotar.ujkocsi(new Kocsi("Fiat", 29703491, 1980), 8);
        autotar.ujkocsi(new Kocsi("BMW", 9145600, 1984), 9);
        autotar.ujkocsi(new Kocsi("Skoda", 12624805, 1994), 10);

        System.out.println("mennyiUjabb");
        System.out.println(autotar.mennyiUjabb(2003));
        System.out.println();
        System.out.println("kevesebbMint");
        autotar.kevesebbMint(27428548);
        System.out.println();
    }
}

// Megoldás
public class Tarolo {
    private Kocsi[] autok;
    private int meret;
    private int szabadIndex;

    public Tarolo(int meret) {
        this.meret = meret;
        this.autok = new Kocsi[meret];
        this.szabadIndex = 0;
    }

    public void ujkocsi(Kocsi kocsi, int index) {
        autok[index] = kocsi;
        szabadIndex++;
    }

    public int mennyiUjabb(int ev) {
        int darabszam = 0;
        for (int i = 0; i < szabadIndex; i++) {
            if (autok[i].getEvjarat() > ev) {
                darabszam++;
            }
        }
        return darabszam;
    }

    public void kevesebbMint(int vetelar) {
        for (int i = 0; i < szabadIndex; i++) {
            if (autok[i].getVetelar() < vetelar) {
                System.out.println(autok[i].getGyarto() + " " + autok[i].getVetelar() + " " + autok[i].getEvjarat());
            }
        }
    }
}
