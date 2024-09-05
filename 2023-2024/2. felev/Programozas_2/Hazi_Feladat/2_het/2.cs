/**
 * Készítse el a MyClass osztályt a megfelelő metódusokkal, hogy a példában megjelölt kód működjön.
 * Ujszam metódus: bekér és visszaad egy egész értéket. 
 * SetVal metódus: a paraméterben kapott egész értéket elmenti az objektumban. 
 * Kiir metódus: megjeleníti a tárolt értéket, a látható szöveg kíséretében (a kimenetre figyelni kell, minden karakter számít).
 *
 * Input: 19, 59
 * Output: 19, Hello world : 59
 */

using System;

namespace HomeWork
{

    //  ======================================================
    class MyClass
    {
        private int _ertek;

        public int Ujszam()
        {
            return int.Parse(Console.ReadLine());
        }

        public void SetVal(int ertek)
        {
            _ertek = ertek;
        }

        public void Kiir()
        {
            Console.WriteLine($"Hello world : {_ertek}");
        }
    }
    //  ======================================================


    class Program
    {
        public static void Main(string[] args)
        {
            MyClass testvar = new MyClass();
            int i = testvar.Ujszam();
            Console.WriteLine(i);
            i = int.Parse(Console.ReadLine());
            testvar.SetVal(i);
            testvar.Kiir();
        }
    }
}