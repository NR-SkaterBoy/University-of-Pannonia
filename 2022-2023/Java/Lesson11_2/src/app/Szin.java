package app;

public abstract class Szin {

    public void kiir(){
        System.out.println("(" + (int)R() + ", " + (int)G() + ", " + (int)B() + ")");
    }
    
    public abstract char R();
    public abstract char G();
    public abstract char B();

    
    
}
