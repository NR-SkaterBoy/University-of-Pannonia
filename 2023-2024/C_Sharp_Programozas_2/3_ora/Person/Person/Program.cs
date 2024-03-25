using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Kiss József", 32);
            Person p2 = new Person("Nagy Mária", 20);
            p1.Write();
            p2.Write();

            // Hallgato teszt: létrehozás és kiir függvény
            Console.WriteLine();

            Student s1 = new Student("Tesz Anna", 21, "ABCDEF");
            Student s2 = new Student("Hegeszt Elek", 19, "XYZXYZ", 5);
            s1.Write();
            s2.Write();

            // Student teszt: Strange függvény
            Console.WriteLine();

            Console.WriteLine($"{s1.FullName}: {s1.Strange()}");
            Console.WriteLine($"{s2.FullName}: {s2.Strange()}");

            // Person teszt: Younger függvény
            Console.WriteLine();

            if (p1.Younger(p2))
            {
                Console.WriteLine($"{p1.FullName} fiatalabb nala: {p2.FullName}");
            }
            else
            {
                Console.WriteLine($"{p1.FullName} idosebb nala: {p2.FullName}");
            }

            if (p2.Younger(s1))
            {
                Console.WriteLine($"{p2.FullName} fiatalabb nala: {s1.FullName}");
            }
            else
            {
                Console.WriteLine($"{p2.FullName} idosebb nala: {s1.FullName}");
            }

            if (s1.Younger(s2))
            {
                Console.WriteLine($"{s1.FullName} fiatalabb nala: {s2.FullName}");
            }
            else
            {
                Console.WriteLine($"{s1.FullName} idosebb nala: {s2.FullName}");
            }

            if (s2.Younger(p1))
            {
                Console.WriteLine($"{s2.FullName} fiatalabb nala: {p1.FullName}");
            }
            else
            {
                Console.WriteLine($"{s2.FullName} idosebb nala: {p1.FullName}");
            }

            Console.ReadKey();
        }
    }
}