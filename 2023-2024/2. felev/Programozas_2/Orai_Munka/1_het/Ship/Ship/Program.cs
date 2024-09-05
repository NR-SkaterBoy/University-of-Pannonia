using System;

namespace Ship
{
    class Ship
    {
        public string _hajoNev;
        public int _szemelyekSzama;
        public double _sebesseg;
        public bool _teherhajo;
    }

    internal class Program
    {
        static Ship[] BekerHajoAdatai(int hajokSzama)
        {
            Ship[] ships = new Ship[hajokSzama];
            for (int i = 0; i < hajokSzama; i++)
            {
                ships[i] = new Ship();
                Console.WriteLine($"Add mag az {i + 1} hajo adatait!");
                Console.Write("Hajo neve: ");
                ships[i]._hajoNev = Console.ReadLine();
                Console.Write("Hany szemely utazhat a hajon: ");
                ships[i]._szemelyekSzama = int.Parse(Console.ReadLine());
                Console.Write("A hajo maximalis sebessege: ");
                ships[i]._sebesseg = double.Parse(Console.ReadLine());
                Console.Write("Teherhajo: ");
                ships[i]._teherhajo = bool.Parse(Console.ReadLine());
            }
            return ships;
        }

        static void KiirHajoAdatai(Ship[] ship)
        {
            for (int i = 0; i < ship.Length; i++)
            {
                Console.WriteLine($"Neve: {ship[i]._hajoNev}, Utasok szama: {ship[i]._szemelyekSzama}, Sebessege: {ship[i]._sebesseg}, Teherhajo: {ship[i]._teherhajo}");
            }
        }

        static int Szallit(Ship[] ships, int max = 100)
        {
            int szallitdb = 0;
            foreach (var ferohely in  ships)
            {
                if (ferohely._szemelyekSzama >= max)
                {
                    szallitdb++;
                }
            }
            return szallitdb;
        }

        static Ship LeglassabbHajo(Ship[] ship, bool teherhajo = false)
        {
            int slowest = 0;
            for (int i = 0; i < ship.Length; i++) if (ship[i]._sebesseg < ship[slowest]._sebesseg) slowest = i;
            return ship[slowest];
        }

        static void Main(string[] args)
        {
            Console.Write("Hany hajo adatat taroljuk? Hajok szama: ");
            int hajokSzama = int.Parse(Console.ReadLine());
            Ship[] ship = BekerHajoAdatai(hajokSzama);
            KiirHajoAdatai(ship);
            Console.WriteLine($"400 fot kepes szallitani: {Szallit(ship, 400)}db hajo van");
            Console.WriteLine($"100 fot kepes szallitani: {Szallit(ship)}db hajo van");
            Console.Write("Teherhajo legyen? (true vagy 1)");
            string teherHajoLegyen = Console.ReadLine();
            if (teherHajoLegyen.Contains("true") || teherHajoLegyen.Contains("1"))
                Console.WriteLine($"Leglassabb hajo {LeglassabbHajo(ship, true)}:");
            else
                Console.WriteLine($"Leglassabb teherhajo {LeglassabbHajo(ship)}:");

            Console.ReadKey();
        }
    }
}
