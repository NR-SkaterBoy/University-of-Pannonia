/**
 * Készíts egy megjelenit függvényt, amely paraméterben egy Szemely objektumot kap, és megjeleníti az adatait a minta szerint!

 * Input:   (Gabor, 34), (Anna, 29)
 * Output:  (nev: Gabor, eletkor: 34), (nev: Anna, eletkor: 29)
 */

using System;

namespace HomeWork
{
    class Szemely
    {
        public string nev;
        public int eletkor;
    }

    class Program
    {
        
        //  ======================================================
        static void megjelenit(Szemely sz)
        {
            Console.WriteLine($"nev: {sz.nev}, eletkor: {sz.eletkor}");
        }
        //  ======================================================

        public static void Main(string[] args)
        {
            Szemely sz1 = new Szemely();
            Szemely sz2 = new Szemely();
            sz1.nev = Console.ReadLine();
            sz1.eletkor = int.Parse(Console.ReadLine());
            sz2.nev = Console.ReadLine();
            sz2.eletkor = int.Parse(Console.ReadLine());
            megjelenit(sz1);
            megjelenit(sz2);
        }
    }
}