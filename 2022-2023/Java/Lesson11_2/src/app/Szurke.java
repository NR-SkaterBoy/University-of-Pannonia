/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package app;

/**
 *
 * @author nrric
 */
public class Szurke extends Szin {

    public final double rate;

    public Szurke(double rate) {
        this.rate = rate;
    }

    @Override
    public char R() {
        return (char) (rate * 255);
    }

    @Override
    public char G() {
        return (char) (rate * 255);
    }

    @Override
    public char B() {
        return (char) (rate * 255);

    }

}
