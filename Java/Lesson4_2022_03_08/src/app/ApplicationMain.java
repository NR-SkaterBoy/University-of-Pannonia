package app;

import java.io.IOException;
import java.nio.file.Paths;
import java.util.Scanner;

public class ApplicationMain {

    public static void main(String[] args) throws IOException {
        Scanner input = new Scanner(System.in);
        
        // // Létrehozás
		 System.out.println("Kerek egy megjegyzest: ");
		 String megj = input.nextLine();
		 DatumLista dl1 = new DatumLista(3, megj);
		 System.out.println(dl1.getMegjegyzes());
		 dl1.setMegjegyzes("At is allitom");
		 System.out.println(dl1.getMegjegyzes());
                 
                 // Eddig jó
		// // Dátumok bekérése és beállítása
		 System.out.println();
		 dl1.setDatum(10000, new Datum(1, 1, 1)); // Ez nem csinál semmit
		 for (int i = 0; i < dl1.getDarab(); i++)
		 {
				 System.out.println("Kerek egy datumot (ev, honap, nap): ");
				 int e = input.nextInt();
				 int h = input.nextInt();
				 int n = input.nextInt();
				 dl1.setDatum(i, new Datum(e, h, n));
		 }
		 dl1.kiir();

		// // Másolat készítése
		 System.out.println();
		 DatumLista dl2 = new DatumLista(dl1);
		 dl1.kiir();
			 dl2.kiir();
		 dl2.setMegjegyzes("Ez a masodik");
		 dl2.setDatum(0, new Datum(1900, 1, 1));
		 dl1.kiir();
                 dl2.kiir();

		// // Hozzáadás és legkorábbi
		// System.out.println();
		// dl1.hozzaad(new Datum(2018, 10, 10));
		// dl1.hozzaad(new Datum(2019, 11, 11));
		// dl1.kiir();
		// Datum legkorabbi = dl1.legkorabbi();
		// System.out.println("A legkorabbi datum: " + legkorabbi.getEv() + "." +
									// legkorabbi.getHonap() + "." + legkorabbi.getNap());
								
		// // Fájlkezelés
         try(Scanner in = new Scanner(Paths.get("datumok.txt"))){
             DatumLista fajlkezeles = new DatumLista(5, "Fajl muveletek");
             fajlkezeles.feltolt(in);
             //fajlkezeles.logbaIras("mentes.txt");
            
             DatumLista masikFajlos = new DatumLista(2, "Fajl muveletek 2");
             masikFajlos.feltolt(in);
            // masikFajlos.logbaIras("mentes.txt");
         }
    }
    
}
