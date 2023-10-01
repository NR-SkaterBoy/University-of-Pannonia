package app;

public class Pont {

    private final int x;
    private final int y;

    public Pont(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }
    
    public void kiir(){
        System.out.println("(" + x + ";" + y + ")");
    }
    
}
