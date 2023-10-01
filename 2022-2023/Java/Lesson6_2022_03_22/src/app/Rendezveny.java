package app;

/**
 *
 * @author nrric
 */
public class Rendezveny extends Szamsor {

    private Szemely kiemeltVendeg;
    
    public Rendezveny() {
        super(7);
    }

    public Szemely getKiemeltVendeg() {
        return kiemeltVendeg;
    }

    public void setKiemeltVendeg(Szemely kiemeltVendeg) {
        this.kiemeltVendeg = kiemeltVendeg;
    }
    
    
    @Override
    public void kiir() {
        System.out.println("Rendezvény:");
        super.kiir();
        if (kiemeltVendeg != null) System.out.println(this.kiemeltVendeg.vezetekNev);
    }
    
    public Rendezveny(Rendezveny r) {
        super(r);
        this.kiemeltVendeg = new Szemely(r.getKiemeltVendeg().getVezetekNev(),
                r.getKiemeltVendeg().getKeresztnev(), 
                r.getKiemeltVendeg().getEletkor());
    }
    
    public void legjobbNap () {
    int max = 0;
    int legjobbNap = 0;
    for (int i = 0; i < tomb.length; i++) {
        if (tomb[i] > max) {
            max = tomb[i];
            legjobbNap = i + 1;
        }
    }
    System.out.println("A legjobb nap a(z) " + legjobbNap + ". nap volt.");
}

}
