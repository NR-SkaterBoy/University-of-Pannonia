package app;
import java.util.Arrays; // Importálás tömbök használatához
import java.util.Scanner; // Importálás a konzolról való beolvaséshoz


/**
 *
 * @author NR-SkaterBoy
 */

// Konkatenálni


public class AplicationMain {
    
    public static void kiir(Szamok sz) {
        for (int i = 0; i < sz.darabLeker(); i++) {
            if (i > 0) System.out.print(", ");
            System.out.print(sz.ertekLeker(i));
        }
    }
    
    public static void main(String[] args) {
        Szamok sz1 = new Szamok(5, 2.3);
        Szamok sz2 = new Szamok(5, 6.9);
        Szamok sz3 = new Szamok(5, 10.6);
        
        // Lekérjük a tömbnek a nagyságát
        System.out.println(sz1.darabLeker());
        System.out.println(sz2.darabLeker());
        System.out.println(sz3.darabLeker());
        sz1.ertekBeallit(-3, 10);
        sz1.ertekBeallit(3, 10);
        sz1.ertekBeallit(8, 10);
        
        kiir(sz1);
        
        // Házi (median/módusz)
        // Githubra fel fog kerülni ez is hamarosan
    }
}
