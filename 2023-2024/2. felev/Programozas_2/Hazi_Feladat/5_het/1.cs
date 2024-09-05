/**
 * A programban gépjárművek adatait tároljuk: rendszám, évjárat, ár.
 * 
 * Készíts egy programot C# nyelven, amely kettő sort olvas be a bemenetről:
 * a bemeneti és a kimeneti fájl nevét. A bementi fájlban járművek adatai vannak,
 * soronként egy jármű három adatával (lásd példa). A program a kimenet fájlba írja ki a 2000-es,
 * vagy újabb gyártású járművek adatait az áruk szerint növekvő sorrendbe rendezve (az árban egyenlőségek nem lesznek)!
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace hazi5
{
    internal class Program
    {
        class Cars
        {

            private string _rendszam;
            private int _ev;
            private int _ar;
            public Cars(string rendszam, int ev, int ar)
            {
                _rendszam = rendszam;
                _ev = ev;
                _ar = ar;

            }
            public string Rendszam { get { return _rendszam; } }
            public int Ev { get { return _ev; } }
            public int Ar { get { return _ar; } }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            List<Cars> allCar = new List<Cars>();
            using (StreamReader sr = new StreamReader(input))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(' ');
                    string rendszam = values[0];
                    int ev = int.Parse(values[1]);
                    int ar = int.Parse(values[2]);

                    allCar.Add(new Cars(rendszam, ev, ar));
                }
            }

            List<Cars> newerCars = allCar.Where(j => j.Ev >= 2000).ToList();
            newerCars.Sort((a, b) => a.Ar.CompareTo(b.Ar));

            using (StreamWriter sw = new StreamWriter(output))
            {
                foreach (Cars car in newerCars)
                {
                    sw.WriteLine($"{car.Rendszam} {car.Ev} {car.Ar}");
                }
            }
        }
    }
}