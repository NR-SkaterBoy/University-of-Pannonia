using System;

namespace Gyak
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

        public void Beallit(Szemely adat, int index)
        {
            if (0 <= index && index < base._szemelyek.Length) { _szemelyek[index] = adat; }
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