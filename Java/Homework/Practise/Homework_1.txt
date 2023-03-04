public class Osztaly {
    private int value;
    public int ujszam() {
        Scanner input = new Scanner(System.in);
        int number = input.nextInt();
        return number;
    }
    
    public void set(int value) {
        this.value = value;
    }
    
    public void kiir() {
        System.out.println("Hello world : " + this.value);
    }
}