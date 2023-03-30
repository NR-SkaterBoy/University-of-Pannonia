package app;

/**
 *
 * @author nrric
 */
public class Pont3D extends Pont {
    private final int z;
    private static char Nyito = '(';
    private static char Zaro = '(';
    private static int negativZDArab = 0;


    public Pont3D(int x, int y, int z) {
        super(x, y);
        this.z = z;
        if ( z < 0) negativZDArab++;
    }

    public int getZ() {
        return z;
    }

    @Override
    public void kiir() {
        System.out.println(Nyito + "" + getX() + ";" + getY() + ";" + getZ() + Zaro);
    }

    public static void setNyito(char Nyito) {
        Pont3D.Nyito = Nyito;
    }

    public static void setZaro(char Zaro) {
        Pont3D.Zaro = Zaro;
    }

    public static int negativZLetrehozott() {
        return negativZDArab;
    }

    
}
