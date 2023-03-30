/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package app;

/**
 *
 * @author nrric
 */
public class HosszuUt extends Utazas {

    private final String[] atszallasok;

    public HosszuUt(String honnan, String hova, int atszallasokSzama) {
        super(honnan, hova);
        this.atszallasok = new String[atszallasokSzama];
    }

    public int getAtszallasokSzama() {
        return atszallasok.length;
    }

    public void setAtszallas(int index, String helyszin) {
        if (index >= 0 && index < getAtszallasokSzama()) {
            this.atszallasok[index] = helyszin;
        }
    }

    public String getAtszallas(int idx) {
        if (idx >= 0 || idx <= atszallasok.length) {
            return this.atszallasok[idx];
        } else {
            return "";
        }
    }
}
