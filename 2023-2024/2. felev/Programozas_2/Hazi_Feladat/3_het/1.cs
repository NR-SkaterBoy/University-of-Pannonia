/**
 * A mellékelt kódban adott egy Jarmu osztály. Származtass belőle kettő gyerekosztályt:
 * 
 * A Kocsi osztály tároljon egy extra adatot, amely az ajtók száma (egész),
 * a típust (ősosztály adattagja) pedig fixen állítsa "kocsi"-ra.
 * A Repulo osztály tároljon egy extra adatot, ami a repülési magasság (egész),
 * a típust (ősosztály adattagja) pedig fixen állítsa "repulo"-re.
 * Az osztályokat úgy kell megírni, hogy a példa kód működjön, és a megfelelő kimenetet adja.
 */

using System;

namespace HaziFeladat
{
    class Jarmu
    {
        string _tipus;
        int _gyartasEve;
        public Jarmu(string tipus, int gyartasEve)
        {
            _tipus = tipus;
            _gyartasEve = gyartasEve;
        }
        public string Tipus
        {
            get { return _tipus; }
        }
        public int GyartasEve
        {
            get { return _gyartasEve; }
        }
        public void Kiir()
        {
            Console.WriteLine($"tipus: {_tipus}, gyartva: {_gyartasEve}");
        }
    }


    class Kocsi : Jarmu
    {
        private int _ajtokSzama;

        public Kocsi(int gyartasEve, int ajtokSzama) : base("kocsi", gyartasEve)
        {
            _ajtokSzama = ajtokSzama;
        }

        public void Kiir()
        {
            Console.WriteLine($"tipus: {Tipus}, gyartva: {GyartasEve}, ajtok: {_ajtokSzama}");
        }
    }

    //  ======================================================
    class Repulo : Jarmu
    {
        private int _magassag;

        public Repulo(int gyartasEve, int magassag) : base("repulo", gyartasEve)
        {
            _magassag = magassag;
        }

        public void Kiir()
        {
            Console.WriteLine($"tipus: {Tipus}, gyartva: {GyartasEve}, magassag: {_magassag}");
        }
    }
    //  ======================================================


    class Program
    {
        static void JarmuKiir(Jarmu jarmu)
        {
            Console.WriteLine($"{jarmu.Tipus} {jarmu.GyartasEve}");
        }
        static void Main(string[] args)
        {
            Kocsi k1 = new Kocsi(1996, 4);
            Kocsi k2 = new Kocsi(2012, 2);
            Repulo r1 = new Repulo(1980, 1230);
            Repulo r2 = new Repulo(2001, 3200);
            k1.Kiir(); // tipus: kocsi, gyartva: 1996, ajtok: 4
            k2.Kiir(); // tipus: kocsi, gyartva: 2012, ajtok: 2
            r1.Kiir(); // tipus: repulo, gyartva: 1980, magassag: 1230
            r2.Kiir(); // tipus: repulo, gyartva: 2001, magassag: 3200
            Console.WriteLine();
            JarmuKiir(k1); // kocsi 1996
            JarmuKiir(k2); // kocsi 2012
            JarmuKiir(r1); // repulo 1980
            JarmuKiir(r2); // repulo 2001
        }
    }
}