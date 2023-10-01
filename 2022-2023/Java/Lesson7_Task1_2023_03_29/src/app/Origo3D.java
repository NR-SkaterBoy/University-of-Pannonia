package app;

/**
 *
 * @author nrric
 */
public class Origo3D extends Pont3D {

    public Origo3D() {
        super(0, 0, 0);
    }  

    @Override
    public void kiir() {
        super.kiir();
        System.out.println("<" + getX() + ";" + getY() + ";" + getZ() + ">");
    }
    
    
}
