package app;

public class Datum {

    private int ev;
    private int honap;
    private int nap;

    public Datum(int ev, int honap, int nap) {
        this.ev = ev;
        this.honap = honap;
        this.nap = nap;
    }
    
    public void kiir() {
        System.out.println(ev + "." + honap + "." + nap);
    }

    public int getEv() {
        return ev;
    }

    public void setEv(int ev) {
        this.ev = ev;
    }

    public int getHonap() {
        return honap;
    }

    public void setHonap(int honap) {
        this.honap = honap;
    }

    public int getNap() {
        return nap;
    }

    public void setNap(int nap) {
        this.nap = nap;
    }
    
}
