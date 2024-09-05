/**
 * Készíts egy bekeres nevű függvényt, amely megkap egy Teglalap objektumot, és bekéri az adatait!
 *
 * Input:   (43, 67), (23, 66)
 * Output:  (sz: 43, m: 67), (sz: 23, m: 66)
 */

using System;

namespace HomeWork
{
    class Teglalap
    {
        public int szelesseg;
        public int magassag;
    }

    class Program
    {

        //  ======================================================
        public static void bekeres(Teglalap teglalap)
        {
            teglalap.szelesseg = Convert.ToInt32(Console.ReadLine());
            teglalap.magassag = Convert.ToInt32(Console.ReadLine());
        }
        //  ======================================================

        public static void Main(string[] args)
        {
            Teglalap t1 = new Teglalap();
            Teglalap t2 = new Teglalap();
            bekeres(t1);
            bekeres(t2);
            Console.WriteLine($"sz: {t1.szelesseg}, m: {t1.magassag}");
            Console.WriteLine($"sz: {t2.szelesseg}, m: {t2.magassag}");
        }
    }
}