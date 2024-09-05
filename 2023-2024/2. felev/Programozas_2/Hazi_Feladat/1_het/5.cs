/**
 * Készíts egy melyikKisebb függvényt, amely paraméterben kettő várost kap, és kiírja annak a nevét, amelyikben kevesebben laknak!
 *
 * Input:   (Veszprém, 59738), (Szeged, 161879)
 * Output:  Veszprem
 */

using System;

namespace HomeWork
{
    class Varos
    {
        public string nev;
        public int lakosok;
    }

    class Program
    {

        //  ======================================================
        static void melyikKisebb(Varos v, Varos va)
        {
            string varos = v.lakosok < va.lakosok ? v.nev : va.nev;
            Console.Write(varos);
        }
        //  ======================================================

        public static void Main(string[] args)
        {
            Varos v1 = new Varos();
            Varos v2 = new Varos();
            v1.nev = Console.ReadLine();
            v1.lakosok = int.Parse(Console.ReadLine());
            v2.nev = Console.ReadLine();
            v2.lakosok = int.Parse(Console.ReadLine());
            melyikKisebb(v1, v2);
        }
    }
}