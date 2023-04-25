/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package app;

/**
 *
 * @author nrric
 */
public class FeketeFeher extends Szin {

    private boolean isBlack;

    public FeketeFeher(boolean isBlack) {
        this.isBlack = isBlack;
    }

    @Override
    public char R() {
        return (char) (isBlack ? 0 : 255);
    }

    @Override
    public char G() {
        return (char) (isBlack ? 0 : 255);
    }

    @Override
    public char B() {
        return (char) (isBlack ? 0 : 255);

    }

}
