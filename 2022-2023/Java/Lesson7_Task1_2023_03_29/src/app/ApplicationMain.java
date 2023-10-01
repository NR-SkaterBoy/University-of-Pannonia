package app;

public class ApplicationMain {
    
    public static void main(String[] args) {
        // 1. feladat
        // Pont3D osztály, konstruktor, getZ (2 pont)
	{
            System.out.println("1. feladat start");
        
	    System.out.println("Szarmaztatas rendben: " + 
                    (Pont.class.isAssignableFrom(Pont3D.class) ?
                        "IGEN" : 
                        "NEM"));
            Pont3D p1 = new Pont3D(4,5,6);
            Pont3D p2 = new Pont3D(7,8,9);
            System.out.println(p1.getX() + " " + p1.getY() + " " + p1.getZ());
            System.out.println(p2.getX() + " " + p2.getY() + " " + p2.getZ());
            
            System.out.println("1. feladat vege");
	}
        
        System.out.println();
        
        // 2. feladat
        // Pont3D.kiir (2 pont)
	{
            System.out.println("2. feladat start");
        
	    Pont3D p1 = new Pont3D(4,5,6);
            Pont3D p2 = new Pont3D(7,8,9);
            p1.kiir();
            p2.kiir();
            
            System.out.println("2. feladat vege");
	}
        
        System.out.println();
        
        // 3. feladat
        // Pont3D statikus zárójelek (2 pont)
	{
            System.out.println("3. feladat start");
        
            Pont3D p1 = new Pont3D(4,5,6);
            Pont3D p2 = new Pont3D(7,8,9);
            p1.kiir();
            p2.kiir();
            Pont3D.setNyito('[');
            Pont3D.setZaro('}');
            p1.kiir();
            p2.kiir();
            Pont3D.setNyito('<');
            Pont3D.setZaro(']');
            p1.kiir();
            p2.kiir();
            Pont3D.setNyito('(');
            Pont3D.setZaro(')');
            
            System.out.println("3. feladat vege");
	}
        
        System.out.println();
        
        // 4. feladat
        // Pont3D.negativZLetrehozott (2 pont)
	{
            System.out.println("4. feladat start");
        
	    System.out.println(Pont3D.negativZLetrehozott());
            Pont3D p1 = new Pont3D(4,5,-6);
            System.out.println(Pont3D.negativZLetrehozott());
            Pont3D p2 = new Pont3D(1,2,3);
            System.out.println(Pont3D.negativZLetrehozott());
            Pont3D p3 = new Pont3D(7,8,-9);
            System.out.println(Pont3D.negativZLetrehozott());
            
            System.out.println("4. feladat vege");
	}
        
        System.out.println();
        
        // 5. feladat
        // Origo3D osztaly, konstruktor, kiir (2 pont)
	{
            System.out.println("5. feladat start");
        
            System.out.println("Szarmaztatas rendben: " + 
                    (Pont3D.class.isAssignableFrom(Origo3D.class) ?
                        "IGEN" : 
                        "NEM"));
	    Origo3D o = new Origo3D();
            o.kiir();
            Origo3D.setNyito('(');
            Origo3D.setZaro('}');
            o.kiir();
            
            System.out.println("5. feladat vege");
	}
        
    }
    
}
