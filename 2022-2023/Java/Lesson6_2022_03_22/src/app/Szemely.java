package app;

public class Szemely {

    protected String vezetekNev;
    protected String keresztnev;
    protected int eletkor;

    public Szemely(String vezetekNev, String keresztnev, int eletkor) {
        this.vezetekNev = vezetekNev;
        this.keresztnev = keresztnev;
        this.eletkor = eletkor;
    }
    
    public String teljesNev(){
        return vezetekNev + " " + keresztnev;
    }
    
    public void kiir(){
        System.out.println(teljesNev() + ": " + eletkor);
    }
    
    public boolean fiatalabb(Szemely sz){
        return eletkor < sz.eletkor;
    }

    public String getVezetekNev() {
        return vezetekNev;
    }

    public String getKeresztnev() {
        return keresztnev;
    }

    public int getEletkor() {
        return eletkor;
    }
    
}
