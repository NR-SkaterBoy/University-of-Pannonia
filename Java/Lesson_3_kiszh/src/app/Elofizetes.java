package app;

/**
 *
 * @author NR-SkaterBoy
 */
public class Elofizetes {
    private final Szolgaltatas[] szolgaltatasok;
    
    public Elofizetes() {
        this.szolgaltatasok = new Szolgaltatas[0];
    }
    
    public Elofizetes(int tipus) {
        switch (tipus) {
            case 0:
                this.szolgaltatasok = new Szolgaltatas[2];
                this.szolgaltatasok[0] = new Szolgaltatas("Netflix", 2500);
                this.szolgaltatasok[1] = new Szolgaltatas("Disney+", 2100);
                break;
            case 1:
                this.szolgaltatasok = new Szolgaltatas[3];
                this.szolgaltatasok[0] = new Szolgaltatas("Prime Video", 900);
                this.szolgaltatasok[1] = new Szolgaltatas("Disney+", 2100);
                this.szolgaltatasok[2] = new Szolgaltatas("HBO max", 1900);
                break;
            default:
                this.szolgaltatasok = new Szolgaltatas[2];
                this.szolgaltatasok[0] = new Szolgaltatas("HBO max", 1900);
                this.szolgaltatasok[1] = new Szolgaltatas("Netflix", 2500);
        }
    }
}
