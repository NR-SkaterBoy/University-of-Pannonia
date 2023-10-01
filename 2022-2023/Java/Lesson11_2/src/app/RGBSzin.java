/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package app;

/**
 *
 * @author nrric
 */
public class RGBSzin extends Szin {
    private final char r;
    private final char g;
    private final char b;

    public RGBSzin(char r, char g, char b) {
        this.r = r;
        this.g = g;
        this.b = b;
    }
    
    public RGBSzin() {
        this((char)0, (char)0, (char)0);
    }

    @Override
    public char R() {
        return r;
    }

    @Override
    public char G() {
        return g;
    }

    @Override
    public char B() {
        return b;
    }

    
}
