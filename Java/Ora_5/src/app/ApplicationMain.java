package app;

public class ApplicationMain {

    
    
    public static void main(String[] args) {
        
        Rendezveny r = new Rendezveny();
        
        // Szamsor teszt: meglévő kódok
		 Szamsor s1 = new Szamsor(3);
		 s1.setErtek(0,5);
		 s1.setErtek(1,6);
		 s1.setErtek(2,7);
		 Szamsor s2 = new Szamsor(8);
		 s2.setErtek(0,3);
		 s2.setErtek(1,1);
		 s2.setErtek(2,-9);
		 s2.setErtek(3,-1);
		 s2.setErtek(4,-4);
		 s2.setErtek(5,1);
		 s2.setErtek(6,10);
		 s2.setErtek(7,-5);

		 s1.kiir();
		 s2.kiir();

		 // Rendezveny teszt: kiírás
		 System.out.println();
		 Rendezveny r1 = new Rendezveny(), r2 = new Rendezveny();
		 r1.setErtek(0,5);
		 r1.setErtek(1,6);
		 r1.setErtek(2,3);
		 r1.setErtek(3,7);
		 r1.setErtek(4,8);
		 r1.setErtek(5,4);
		 r1.setErtek(6,9);

		 r2.setErtek(0,1);
		 r2.setErtek(1,10);
		 r2.setErtek(2,2);
		 r2.setErtek(3,4);
		 r2.setErtek(4,5);
		 r2.setErtek(5,2);
		 r2.setErtek(6,6);
		 r2.setKiemeltVendeg(new Szemely("Vendeg", "Piroska", 30));

		 r1.kiir();
		 r2.kiir();

		// // Rendezveny teszt: másoló konstruktor
		 System.out.println();
		 Rendezveny masolat = new Rendezveny(r2);
		 masolat.kiir();
		 masolat.setErtek(4,123);
		 masolat.setErtek(1,222);
		 masolat.kiir();

		// // Rendezveny teszt: legjobb nap
		 System.out.println();
		 r1.legjobbNap();
		 r2.legjobbNap();

		// // Szamsor teszt: kisebb átlag
		// System.out.println();
		// System.out.println("Atlag osszehasonlitas: s1 vs s2: ");
		// kisebbAtlag(s1,s2);
		// System.out.println("Atlag osszehasonlitas: s2 vs r1: ");
		// kisebbAtlag(s2,r1);
		// System.out.println("Atlag osszehasonlitas: r1 vs r2: ");
		// kisebbAtlag(r1,r2);
		// System.out.println("Atlag osszehasonlitas: r2 vs s1: ");
		// kisebbAtlag(r2,s1);
		// System.out.println("Atlag osszehasonlitas: s1 vs r1: ");
		// kisebbAtlag(s1,r1);
		// System.out.println("Atlag osszehasonlitas: s2 vs r2: ");
		// kisebbAtlag(s2,r2);
                
                
//                public static void kisebbAtlag(Szamsor s1, Szamsor s2) {
//                    double atlag = 0;
//                    for (int i = 0; i < tomb.; i++) {
//                        
//                    }
//                }
    }
    
}
