package app;

public class Szamsor {

    protected int[] tomb;
    
    public Szamsor(int darab){
        tomb = new int[darab];
    }
    
    public Szamsor(Szamsor s){
        tomb = new int[s.tomb.length];
        for(int i = 0; i < tomb.length; ++i){
            tomb[i] = s.tomb[i];
        }
    }
    
    public int getDarab(){
        return tomb.length;
    }
    
    public int getErtek(int index){
        return tomb[index];
    }
    
    public void setErtek(int index, int ertek){
        if(index < tomb.length){
            tomb[index] = ertek; 
        }
    }
    
    public void kiir(){
         for(int i = 0; i< tomb.length; ++i){
            if(i > 0) System.out.print(", ");
            System.out.print(tomb[i]);
        }
         System.out.println();
    }
    
    public double atlag() {
        double sum = 0;
        for (int i = 0; i < tomb.length; i++) {
            sum += tomb[i];
        }
        return sum / tomb.length;
    }
}
