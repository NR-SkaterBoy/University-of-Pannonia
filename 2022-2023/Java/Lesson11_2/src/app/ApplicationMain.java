package app;

public class ApplicationMain {

	public static void main(String[] args) {
		// RGBSzin teszt: konstruktor, destruktor
		System.out.println();
		System.out.println("RGBSzin teszt: konstruktor, destruktor");
		Szin szin1 = new RGBSzin((char)123, (char)54, (char)65);
		
	        
		// RGBSzin teszt: R, G, B függvények
		System.out.println();
		System.out.println("RGBSzin teszt: R, G, B");
		Szin szin2 = new RGBSzin((char)29, (char)124, (char)243);
		szin2.kiir(); // (29,124,243)
		
		szin2=new RGBSzin();
		szin2.kiir(); // (0,0,0)
		
	        
		// FeketeFeher teszt: R, G, B függvények
		System.out.println();
		System.out.println("FeketeFeher teszt: R, G, B");
		Szin szin3=new FeketeFeher(true);
		szin3.kiir(); // (0,0,0)
		
		szin3 = new FeketeFeher(false);
		szin3.kiir(); // (255,255,255)
	//	
	//        
		// Szurke teszt: R, G, B függvények
		System.out.println();
		System.out.println("Szurke teszt: R, G, B");
		Szin szin4=new Szurke(0);
		szin4.kiir(); // (0,0,0)
		
		szin4 = new Szurke(1);
		szin4.kiir(); // (255,255,255)
		
		szin4 = new Szurke(0.5);
		szin4.kiir(); // (127,127,127)
		
		szin4 = new Szurke(0.8);
		szin4.kiir(); // (204,204,204)
		
	//
	//	// Szin teszt: szamotHexava, hexatSzamma függvények
	//	System.out.println();
	//	System.out.println("Szin teszt: szamotHexava, hexatSzamma");
	//	System.out.println(Szin.szamotHexava(0)); // 0
	//	System.out.println(Szin.szamotHexava(5)); // 5
	//	System.out.println(Szin.szamotHexava(9)); // 9
	//	System.out.println(Szin.szamotHexava(10)); // A
	//	System.out.println(Szin.szamotHexava(12)); // C
	//	System.out.println(Szin.szamotHexava(15)); // F
	//	System.out.println(Szin.hexatSzamma('0')); // 0
	//	System.out.println(Szin.hexatSzamma('3')); // 3
	//	System.out.println(Szin.hexatSzamma('9')); // 9
	//	System.out.println(Szin.hexatSzamma('A')); // 10
	//	System.out.println(Szin.hexatSzamma('E')); // 14
	//	System.out.println(Szin.hexatSzamma('F')); // 15
	//
	//        
	//	// Szin teszt: printCode függvény
	//	System.out.println();
	//	System.out.println("Szin teszt: printCode");
	//	Szin szin5 = new RGBSzin((char)120, (char)65, (char)234);
	//	System.out.println(szin5.printCode()); // #7841EA
	//	
	//	szin5 = new RGBSzin((char)6, (char)54, (char)15);
	//	System.out.println(szin5.printCode()); // #06360F
	//	
	//	szin5 = new RGBSzin((char)212, (char)200, (char)253);
	//	System.out.println(szin5.printCode()); // #D4C8FD
	//	
	//	szin5 = new RGBSzin((char)128, (char)96, (char)177);
	//	System.out.println(szin5.printCode()); // #8060B1
	//	
	//	szin5 = new FeketeFeher(false);
	//	System.out.println(szin5.printCode()); // #FFFFFF
	//	
	//	szin5 = new Szurke(0.4);
	//	System.out.println(szin5.printCode()); // #666666
	//	
	//
	//	// SzovegesSzin teszt: konstruktor, R, G, B függvények
	//	System.out.println();
	//	System.out.println("SzovegesSzin teszt: konstruktor, R, G, B");
	//	Szin szin6 = new SzovegesSzin("piros");
	//	szin6.kiir(); // (255,0,0)
	//	
	//	szin6 = new SzovegesSzin("sarga");
	//	szin6.kiir(); // (255,255,0)
	//	
	//	szin6 = new SzovegesSzin("kek");
	//	szin6.kiir(); // (0,0,255)
	//	
	//	szin6 = new SzovegesSzin("ilyenincs");
	//	szin6.kiir(); // (0,0,0)
	//	
	//	// SzovegesSzin teszt: konstruktor hexa formában
	//	System.out.println();
	//	System.out.println("SzovegesSzin teszt: konstruktor hexa forma");
	//	Szin szin7 = new SzovegesSzin("#E4CB27");
	//	szin7.kiir(); // (228,203,39)
	//	
	//	szin7 = new SzovegesSzin("#D4C8FD");
	//	szin7.kiir(); // (212,200,253)
	//	
	//	szin7 = new SzovegesSzin("#FF00FF");
	//	szin7.kiir(); // (255,0,255)
	//	
	//	// SzovegesSzin teszt: printCode függvény
	//	System.out.println();
	//	System.out.println("SzovegesSzin teszt: printCode");
	//	Szin szin8 = new SzovegesSzin("#666666");
	//	System.out.println(szin8.printCode()); // #666666
	//	
	//	szin8 = new SzovegesSzin("magenta");
	//	System.out.println(szin8.printCode()); // magenta
	//	
	//	szin8 = new SzovegesSzin("nincs ilyen ezert fekete lesz");
	//	System.out.println(szin8.printCode()); // fekete
	//	
	//	// Szin teszt: megegyezik függvény
	//	System.out.println();
	//	System.out.println("Szin teszt: megegyezik");
	//	Szin szin9 = new RGBSzin((char)212, (char)200, (char)253);
	//	Szin szin10 = new Szurke(1);
	//	Szin szin11 = new SzovegesSzin("#D4C8FD");
	//	Szin szin12 = new SzovegesSzin("feher");
	//	szin9.kiir(); // (212,200,253)
	//	szin10.kiir(); // (255,255,255)
	//	szin11.kiir(); // (212,200,253)
	//	szin12.kiir(); // (255,255,255)
	//	System.out.println(szin9.megegyezik(szin10)); // false
	//	System.out.println(szin10.megegyezik(szin12)); // true
	//	System.out.println(szin12.megegyezik(szin11)); // false
	//	System.out.println(szin11.megegyezik(szin9)); // true
	//	
	//	// RGBSzin teszt: konstruktor másolat
	//	System.out.println();
	//	System.out.println("RGBSzin teszt: konstruktor masolat");
	//	Szin szin13 = new SzovegesSzin("#E4CB27");
	//	szin13.kiir(); // (228,203,39)
	//	Szin szin14 = new RGBSzin(szin13);
	//	szin14.kiir(); // (228,203,39)
	//	
	//	szin13 = new Szurke(0.3);
	//	szin13.kiir(); // (76,76,76)
	//	szin14 = new RGBSzin(szin13);
	//	szin14.kiir(); // (76,76,76)
    }
    
}
