class MyClass {
    private int ertek;
    private int x;
    
    public MyClass(int ertek, int x) {
        this.ertek = ertek;
        this.x = x;
    }
    
    public MyClass() {
        this(1009, 1267);
    }
    
    public int getErtek() {
        return this.ertek;
    }
    
    public int getX() {
        return this.x;
    }
    
    // Matematikai minimum fvg-t meghívva a két érték közül a kisebbel tér vissza
    public int lekerdez() {
        return Math.min(this.ertek, this.x);
    }
}