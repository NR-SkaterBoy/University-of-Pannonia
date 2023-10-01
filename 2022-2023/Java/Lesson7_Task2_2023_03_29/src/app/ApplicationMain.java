package app;

import java.io.IOException;

public class ApplicationMain {

    public static void main(String[] args) throws IOException {
        
        // 1. feladat
        {
            System.out.println("1. feladat");
            
            System.out.print("HosszuUt az Utazas-bol szarmazik? : ");
            System.out.print(Utazas.class.isAssignableFrom(HosszuUt.class)?"IGEN":"NEM");
            System.out.print("\n");
            HosszuUt ut = new HosszuUt("Budapest", "London", 2);
            System.out.print(ut.getHonnan());
            System.out.print(" -> ");
            System.out.print(ut.getHova());
            System.out.print("\n");
	}

        System.out.println();
        
        // 2. feladat
        {
            System.out.println("2. feladat");
            
            HosszuUt ut1 = new HosszuUt("Budapest", "London", 2);
            System.out.print(ut1.getHonnan());
            System.out.print(" -> ");
            System.out.print(ut1.getHova());
            System.out.print("\n");
            System.out.print(ut1.getAtszallasokSzama());
            System.out.print("\n");
            HosszuUt ut2 = new HosszuUt("San Francisco", "Madrid", 4);
            System.out.print(ut2.getHonnan());
            System.out.print(" -> ");
            System.out.print(ut2.getHova());
            System.out.print("\n");
            System.out.print(ut2.getAtszallasokSzama());
            System.out.print("\n");
	}

        System.out.println();
        
        // 3. feladat
        {
            System.out.println("3. feladat");
            
            HosszuUt ut = new HosszuUt("San Francisco", "Madrid", 4);
            ut.setAtszallas(1,"London");
            ut.setAtszallas(3,"Rome");
            ut.setAtszallas(4,"Budapest");
            ut.setAtszallas(2,"Paris");
            ut.setAtszallas(0,"New York");

	}

        System.out.println();
        
        // 4. feladat
        {
            System.out.println("4. feladat");
            
//            HosszuUt ut1 = new HosszuUt("San Francisco", "Madrid", 4);
//            ut1.setAtszallas(1,"London");
//            ut1.setAtszallas(3,"Rome");
//            ut1.setAtszallas(4,"Budapest");
//            ut1.setAtszallas(2,"Paris");
//            ut1.setAtszallas(0,"New York");
//            final HosszuUt ut1r = ut1;
//            System.out.print(ut1r.getHonnan());
//            for (int i = 0; i < ut1r.getAtszallasokSzama(); i++)
//            {
//                System.out.print(" -> ");
//                System.out.print(ut1r.getAtszallas(i));
//            }
//            System.out.print(" -> ");
//            System.out.print(ut1r.getHova());
//            System.out.print("\n");
//
//            HosszuUt ut2 = new HosszuUt("Budapest", "London", 2);
//            ut2.setAtszallas(1,"Paris");
//            ut2.setAtszallas(3,"Rome");
//            ut2.setAtszallas(0,"Graz");
//            ut2.setAtszallas(7,"Madrid");
//            final HosszuUt ut2r = ut2;
//            System.out.print(ut2r.getHonnan());
//            for (int i = 0; i < ut2r.getAtszallasokSzama(); i++)
//            {
//                System.out.print(" -> ");
//                System.out.print(ut2r.getAtszallas(i));
//            }
//            System.out.print(" -> ");
//            System.out.print(ut2r.getHova());
//            System.out.print("\n");
//
//            System.out.print("elvileg ures: ");
//            System.out.print(ut1r.getAtszallas(4));
//            System.out.print("\n");
//            System.out.print("elvileg ures: ");
//            System.out.print(ut2r.getAtszallas(3));
//            System.out.print("\n");

	}

        System.out.println();
        
        // 5. feladat
        {
            System.out.println("5. feladat");
            
//            System.out.print(HosszuUt.getMaxAtszallas());
//            System.out.print("\n");
//            HosszuUt.setMaxAtszallas(2);
//            System.out.print(HosszuUt.getMaxAtszallas());
//            System.out.print("\n");
//            HosszuUt.setMaxAtszallas(4);
//            System.out.print(HosszuUt.getMaxAtszallas());
//            System.out.print("\n");

	}

        System.out.println();
        
        // 6. feladat
        {
            System.out.println("6. feladat");
            
//            HosszuUt ut1 = new HosszuUt("Budapest", "London", 2);
//            HosszuUt ut2 = new HosszuUt("San Francisco", "Madrid", 4);
//            System.out.print(HosszuUt.getMaxAtszallas());
//            System.out.print("\n");
//            System.out.print("ut1: ");
//            System.out.print((ut1.tulSokAtszallas()?"TUL HOSSZU":"RENDBEN VAN"));
//            System.out.print("\n");
//            System.out.print("ut2: ");
//            System.out.print((ut2.tulSokAtszallas()?"TUL HOSSZU":"RENDBEN VAN"));
//            System.out.print("\n");
//            HosszuUt.setMaxAtszallas(2);
//            System.out.print(HosszuUt.getMaxAtszallas());
//            System.out.print("\n");
//            System.out.print("ut1: ");
//            System.out.print((ut1.tulSokAtszallas()?"TUL HOSSZU":"RENDBEN VAN"));
//            System.out.print("\n");
//            System.out.print("ut2: ");
//            System.out.print((ut2.tulSokAtszallas()?"TUL HOSSZU":"RENDBEN VAN"));
//            System.out.print("\n");
//            HosszuUt.setMaxAtszallas(1);
//            System.out.print(HosszuUt.getMaxAtszallas());
//            System.out.print("\n");
//            System.out.print("ut1: ");
//            System.out.print((ut1.tulSokAtszallas()?"TUL HOSSZU":"RENDBEN VAN"));
//            System.out.print("\n");
//            System.out.print("ut2: ");
//            System.out.print((ut2.tulSokAtszallas()?"TUL HOSSZU":"RENDBEN VAN"));
//            System.out.print("\n");
//            HosszuUt.setMaxAtszallas(4);
//            System.out.print(HosszuUt.getMaxAtszallas());
//            System.out.print("\n");
//            System.out.print("ut1: ");
//            System.out.print((ut1.tulSokAtszallas()?"TUL HOSSZU":"RENDBEN VAN"));
//            System.out.print("\n");
//            System.out.print("ut2: ");
//            System.out.print((ut2.tulSokAtszallas()?"TUL HOSSZU":"RENDBEN VAN"));
//            System.out.print("\n");

	}

        System.out.println();
        
        // 7. feladat
        {
            System.out.println("7. feladat");
            
//            HosszuUt hosszuUt1 = HosszuUt.beolvas("hosszuut1.txt");
//            System.out.print(hosszuUt1.getHonnan());
//            for (int i = 0; i < hosszuUt1.getAtszallasokSzama(); i++)
//            {
//                System.out.print(" -> ");
//                System.out.print(hosszuUt1.getAtszallas(i));
//            }
//            System.out.print(" -> ");
//            System.out.print(hosszuUt1.getHova());
//            System.out.print("\n");
//            
//            HosszuUt hosszuUt2 = HosszuUt.beolvas("hosszuut2.txt");
//            System.out.print(hosszuUt2.getHonnan());
//            for (int i = 0; i < hosszuUt2.getAtszallasokSzama(); i++)
//            {
//                System.out.print(" -> ");
//                System.out.print(hosszuUt2.getAtszallas(i));
//            }
//            System.out.print(" -> ");
//            System.out.print(hosszuUt2.getHova());
//            System.out.print("\n");
	}
    }

}
