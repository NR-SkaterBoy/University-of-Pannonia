package app;

/**
 *
 * @author NR-SkaterBoy
 */
public class Szamok {
    
    public static final double alapertelmezettErtek = Math.pow(10, -8);
    private double Szamok[];
    
    // Az adattag alapesetben mindig private
    private double szamok[]; // A tömb egy referencia típus, nem létezik amíg a constructorban nem hozzuk létre
    
    // Konstruktor, az osztály inicializálásához
    public Szamok(int meret, double ertek) {
        szamok = new double[meret];
        for (int i = 0; i < szamok.length; i++) {
            szamok[i] = ertek;
        }
        
    }
    
    // Különböző konstruktorokat lehet létrehozni
    
    public Szamok(int meret) {
        // This hivatkozik az aktuális constructorra
        // Aktuális constructorra hivatkozik ha a this után pont áll
        // Ezt az aspektust kell ismerni
        this(meret, 0);
    }
    
    // A tömb méretének a lekérése
    public int darabLeker() {
        return this.szamok.length;
    }
    
    // Ha private a fvg akkor csak az aktuális fileból érhető el
    public void ertekBeallit(int idx, double szam) {
       // Ellenőrzi az idnex valósságát
       if (idx >= 0 && idx < szamok.length) {
            szamok[idx] = szam;
       }
    }
    
    public double ertekLeker(int idx) {
        if (idx >= 0 && idx < szamok.length) return szamok[idx];
        // Elfogadott a 10^-8
        return alapertelmezettErtek;
    }
}
