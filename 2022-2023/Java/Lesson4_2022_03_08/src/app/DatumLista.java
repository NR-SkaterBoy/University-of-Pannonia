/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package app;

import java.util.Scanner;

/**
 *
 * @author nrric
 */
public class DatumLista {

    private Datum[] datumok;
    private String megjegyzes;

    public DatumLista(int db, String megjegyzes) {
        this.datumok = new Datum[db];
        this.megjegyzes = megjegyzes;
    }

    public String getMegjegyzes() {
        return megjegyzes;
    }

    public void setMegjegyzes(String megjegyzes) {
        this.megjegyzes = megjegyzes;
    }

    public void setDatum(int idx, Datum datum) {
        if (idx >= 0 && idx < this.datumok.length) {
            this.datumok[idx] = datum;
        }
    }

    public Datum getDatum(int idx) {
        return this.datumok[idx];
    }
    
    public DatumLista(DatumLista dl) {
        this(dl.getDarab(), dl.getMegjegyzes());
        for (int i = 0; i < dl.getDarab(); i++) {
            Datum orig = dl.getDatum(i);
            Datum copy = new Datum(orig.getEv(), orig.getHonap(), orig.getNap());
            this.setDatum(i, copy);
        }
    }
    
    public void hozzaad(Datum d) {
        Datum[] tmp = new Datum[datumok.length + 1];
        for (int i = 0; i < datumok.length; i++) {
            tmp[i] = datumok[i];
        }
        tmp[tmp.length - 1] = d;
        this.datumok = tmp;
        
        // Ez az előző kódnak a rövidített változata
        // this.datumok = Arrayof.copyOf(datumok, datumok.length + 1);
    }
    
    public int getDarab() {
        return datumok.length;
    }
    
    
    public void kiir() {
        System.out.println(megjegyzes);
        for (int i = 0; i < datumok.length; i++) {
            System.out.println("\t");
            datumok[i].kiir();
        }
    }
    
    public void feltolt(Scanner input) {
        for (int i = 0; i < datumok.length; i++) {
            int ev = input.nextInt();
            int honap = input.nextInt();
            int nap = input.nextInt();
            datumok[i] = new Datum(ev, honap, nap);
        }
    }
}