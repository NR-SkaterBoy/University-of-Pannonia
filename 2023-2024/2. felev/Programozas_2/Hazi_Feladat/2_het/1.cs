/**
 * Készítse el a MyClass osztályt kettő egész adattaggal (_darab és _eletkor), valamint a megfelelő metódusokkal, hogy a példában megjelölt kód működjön.
 * Konstruktor: paraméterben megkap két egész értéket és beállítja az adattagokat.
 * A konstruktort lehessen paraméter nélkül is meghívni, ekkor a változók értékei 1116 és 328 legyenek.
 * GetDarab metódus: visszaadja a darab adattag értékét.
 * GetEletkor metódus: visszaadja az eletkor adattag értékét.
 * Visszaad metódus: visszaadja a kettő adattag közül a nagyobbat.
 *
 * Input:   -20, 74
 * Output:  -20, 74, 74, 1116, 328, 1116
 */

using System;

namespace HomeWork
{

    //  ======================================================
    class MyClass
    {
        private int _darab;
        private int _eletkor;
        public MyClass(int darab, int eletkor)
        {
            _darab = darab;
            _eletkor = eletkor;
        }

        // Paraméter nélküli konstruktor
        public MyClass() : this(1116, 328)
        {
        }

        // GetDarab metódus
        public int GetDarab()
        {
            return _darab;
        }

        public int GetEletkor()
        {
            return _eletkor;
        }

        public int Visszaad()
        {
            return Math.Max(_darab, _eletkor);
        }
    }
    //  ======================================================

    class Program
    {
        public static void Main(string[] args)
        {
            int x1, x2;
            x1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            MyClass elso = new MyClass(x1, x2);
            Console.WriteLine(elso.GetDarab());
            Console.WriteLine(elso.GetEletkor());
            Console.WriteLine(elso.Visszaad());
            MyClass masodik = new MyClass();
            Console.WriteLine(masodik.GetDarab());
            Console.WriteLine(masodik.GetEletkor());
            Console.WriteLine(masodik.Visszaad());
        }
    }
}