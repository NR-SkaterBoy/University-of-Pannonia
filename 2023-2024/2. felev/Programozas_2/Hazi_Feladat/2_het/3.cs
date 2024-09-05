/**
 * Készítse el a Szemely osztályt, amely egy személy vezetéknevét, keresztnevét, és telefonszámát tárolja (mindhárom szöveg),
 * az alábbiaknak megfelelően:
 *
 * A vezetéknév és keresztnév egy-egy Property-n keresztül legyen lekérdezhető és beállítható
 * (Property-k nevei: VezetekNev, KeresztNev),
 * Legyen egy csak lekérdezhető Property (TeljesNev), ami visszaadja a vezeték- és keresztnevet összefűzve, egy szóközzel elválasztva,
 * A telefonszámot a TelefonSzam nevű Property-n keresztül lehessen lekérdezni és beállítani, de a beállítás végezzen ellenőrzést:
 * csak pontosan 10 karakteres szöveget fogadjon el, aminek a 3. karaktere '/' (pl: "20/1234567"); ha nem megfelelő értéket adunk meg,
 * akkor a telefonszám értéke az "ERROR" szövegre változzon,
 * A Main-ben hozz létre a peldaSzemely referenciához egy Szemely típusú objektumot,
 * és töltsd fel az értékeit a bemenetről beolvasott adatokkal (3 sor van a bemeneten: vezetéknév, keresztnév, telefonszám).
 */

using System;

namespace HomeWork
{

    //  ======================================================
    class Szemely
    {
        private string vezetekNev;
        private string keresztNev;
        private string telefonSzam;

        public string VezetekNev
        {
            get
            {
                return vezetekNev;
            }
            set
            {
                vezetekNev = value;
            }
        }

        public string KeresztNev
        {
            get
            {
                return keresztNev;
            }
            set
            {
                keresztNev = value;
            }
        }

        public string TeljesNev
        {
            get
            {
                return $"{vezetekNev} {keresztNev}";
            }
        }

        public string TelefonSzam
        {
            get
            {
                return telefonSzam;
            }
            set
            {
                if (value.Length == 10 && value[2] == '/')
                {
                    telefonSzam = value;
                }
                else
                {
                    telefonSzam = "ERROR";
                }
            }
        }
    }
    //  ======================================================


    class Program
    {
        public static void Main(string[] args)
        {
            Szemely peldaSzemely;

            //  ======================================================
            peldaSzemely = new Szemely();
            peldaSzemely.VezetekNev = Console.ReadLine();
            peldaSzemely.KeresztNev = Console.ReadLine();
            peldaSzemely.TelefonSzam = Console.ReadLine();
            //  ======================================================

            Console.WriteLine($"név külön: {peldaSzemely.VezetekNev} {peldaSzemely.KeresztNev}");
            Console.WriteLine($"név egyben: {peldaSzemely.TeljesNev}");
            Console.WriteLine($"telefonszám: {peldaSzemely.TelefonSzam}");
            Console.WriteLine();
            peldaSzemely.VezetekNev = Console.ReadLine();
            peldaSzemely.KeresztNev = Console.ReadLine();
            Console.WriteLine($"név külön: {peldaSzemely.VezetekNev} {peldaSzemely.KeresztNev}");
            Console.WriteLine($"név egyben: {peldaSzemely.TeljesNev}");
            Console.WriteLine();
            peldaSzemely.TelefonSzam = Console.ReadLine();
            Console.WriteLine($"telefonszám: {peldaSzemely.TelefonSzam}");
            peldaSzemely.TelefonSzam = Console.ReadLine();
            Console.WriteLine($"telefonszám: {peldaSzemely.TelefonSzam}");
        }
    }
}