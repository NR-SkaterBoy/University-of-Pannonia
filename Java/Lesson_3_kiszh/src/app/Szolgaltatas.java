package app;

public class Szolgaltatas {

    private String nev;
    private int haviDij;

    public Szolgaltatas(String nev, int haviDij) {
        this.nev = nev;
        this.haviDij = haviDij;
    }

    public String getNev() {
        return nev;
    }

    public void setNev(String nev) {
        this.nev = nev;
    }

    public int getHaviDij() {
        return haviDij;
    }

    public void setHaviDij(int haviDij) {
        this.haviDij = haviDij;
    }
        
}
