/**
 * Adott egy Szemely osztály, amely egy cég egy alkalmazottjának adatait tárolja, valamint egy Munkahely osztály,
 * ami magát a céget (alkalmazottak dinamikus tömbje). Célszerű átnézni ezek kódjait.
 * A Munkahely osztály a konstruktorban kapja meg a belső tömb méretét, amit utána nem lehet kívülről módosítani
 * (mert a növelő függvény protected), de lehet az adatokat lekérdezni és átállítani.
 * 
 * A feladat egy SajatMunkahely osztály elkészítése, amely a Munkahely osztályból származik,
 * és annak egy okosabb verziója. Az osztály a következőket tudja:

 * --- Legyen a Munkahely gyerekosztálya.
 * --- Létrehozáskor üres tárolót hozzon létre (0 elemmel).
 * --- Felül kell írni az ősosztálytól kapott Beallit metódust úgy, hogy ne lehessen érvénytelen hozzárendelés.
 * Ha a metódus olyan index-et kap paraméterben, amelyik nem létezik a tömbben, akkor meg kell növelni a tömb méretét akkorára,
 * hogy érvényes legyen az index (de csak akkorára, amekkora kell). Feltehetjük, hogy negatív indexet nem kap a függvény.
 * Figyelni kell arra, hogy:
 * Az ősosztályban a növelő függvény a hozzáadandó elemek számát várja (nem pedig az új méretet).
 * A tömb érvényes indexeiben a méret nincs benne (a 10-es index akkor lesz érvényes, ha legalább 11 elemű a tömb).
 * Ne legyen nagyobb a tömb, mint ami szükséges (ha a 10-es indexet akarjuk beállítani, és ennél kisebb a tömb,
 * akkor pontosan 11 eleműre méretezzük át, ne többre).
 * --- TobbetKeresMint metódus: megjeleníti az összes olyan Szemely objektumot (a kimeneti minta szerint),
 * amelyekben a fizetés adattag értéke nagyobb, mint a paraméterben kapott érték.
 * --- JobbakSzama metódus: megszámolja és visszaadja azon Szemely objektumok darabszámát,
 * amelyekben az értékelés adattag értéke nagyobb, mint a paraméterben kapott érték.
 */

using System;

namespace HaziFeladat
{
    class Szemely
    {
        public int Fizetes { get; }
        public int Ertekeles { get; }
        public Szemely()
        {
            Fizetes = 0;
            Ertekeles = 0;
        }
        public Szemely(int pFizetes, int pErtekeles)
        {
            Fizetes = pFizetes;
            Ertekeles = pErtekeles;
        }
    }

    class Munkahely
    {
        private Szemely[] _szemelyek;
        protected void Novel(int mennyivel)
        {
            Console.Write($"Hozzaadunk {mennyivel} uj elemet ({_szemelyek.Length}");
            Szemely[] ujtomb = new Szemely[_szemelyek.Length + mennyivel];
            for (int i = 0; i < _szemelyek.Length; i++)
                ujtomb[i] = _szemelyek[i];
            _szemelyek = ujtomb;
            Console.WriteLine($"->{_szemelyek.Length})");
        }
        public Munkahely(int alapmeret = 10)
        {
            Console.WriteLine($"Munkahely letrejott {alapmeret} merettel");
            if (alapmeret <= 0) _szemelyek = new Szemely[0];
            else _szemelyek = new Szemely[alapmeret];
        }
        public int GetMeret()
        {
            return _szemelyek.Length;
        }
        public Szemely Leker(int index)
        {
            if (0 <= index && index < _szemelyek.Length) { return _szemelyek[index]; }
            else { return null; }
        }
        public void Beallit(Szemely adat, int index)
        {
            if (0 <= index && index < _szemelyek.Length) { _szemelyek[index] = adat; }
        }
    }


    class SajatMunkahely : Munkahely
    {
        public SajatMunkahely() : base(0)
        {
        }

        public new void Beallit(Szemely adat, int index)
        {
            if (index < 0)
            {
                Console.WriteLine("Index cannot be negative.");
                return;
            }

            if (index >= GetMeret())
            {
                int newSize = index + 1;
                Novel(newSize - GetMeret());
            }

            base.Beallit(adat, index);
        }

        public void TobbetKeresMint(int ertek)
        {
            for (int i = 0; i < GetMeret(); i++)
            {
                Szemely aktualis = Leker(i);
                if (aktualis.Fizetes > ertek)
                {
                    Console.WriteLine($"{aktualis.Fizetes} {aktualis.Ertekeles}");
                }
            }
        }

        public int JobbakSzama(int ertek)
        {
            int count = 0;
            for (int i = 0; i < GetMeret(); i++)
            {
                Szemely aktualis = Leker(i);
                if (aktualis.Ertekeles > ertek)
                {
                    count++;
                }
            }
            return count;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            // REPLACE IN TEST BEGIN
            // A javito tobb tesztet is futtat, a main mindegyikben mas lesz
            Console.WriteLine("Feltoltes");
            SajatMunkahely sajatceg = new SajatMunkahely();
            sajatceg.Beallit(new Szemely(174765, 81), 5);
            sajatceg.Beallit(new Szemely(255751, 28), 7);
            sajatceg.Beallit(new Szemely(331503, 55), 3);
            sajatceg.Beallit(new Szemely(207726, 82), 8);
            sajatceg.Beallit(new Szemely(154813, 25), 6);
            sajatceg.Beallit(new Szemely(184193, 65), 2);
            sajatceg.Beallit(new Szemely(198256, 16), 1);
            sajatceg.Beallit(new Szemely(238485, 50), 4);
            sajatceg.Beallit(new Szemely(202717, 39), 0);

            Console.WriteLine("\nListazas");
            for (int i = 0; i < sajatceg.GetMeret(); i++)
            {
                Szemely aktualis = sajatceg.Leker(i);
                Console.WriteLine($"{aktualis.Fizetes} {aktualis.Ertekeles}");
            }


            Console.WriteLine("\nStatisztikak");
            Console.WriteLine("TobbetKeresMint");
            sajatceg.TobbetKeresMint(241627);
            Console.WriteLine();
            Console.WriteLine("JobbakSzama");
            Console.WriteLine(sajatceg.JobbakSzama(61));
            Console.WriteLine();

            // REPLACE IN TEST END
            Console.WriteLine("Vege");
        }
    }
}