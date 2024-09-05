using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NumberLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NumberLine teszt: meglévő kódok
            NumberLine nl1 = new NumberLine(3);
            nl1.SetValue(0, 5);
            nl1.SetValue(1, 6);
            nl1.SetValue(2, 7);

            NumberLine nl2 = new NumberLine(8);
            nl2.SetValue(0, 3);
            nl2.SetValue(1, 1);
            nl2.SetValue(2, -9);
            nl2.SetValue(3, -1);
            nl2.SetValue(4, -4);
            nl2.SetValue(5, 1);
            nl2.SetValue(6, 10);
            nl2.SetValue(7, -5);

            WriteNumberLine(nl1);
            WriteNumberLine(nl2);

            // Event teszt: kiírás
            Console.WriteLine();
            Event e1 = new Event();
            Event e2 = new Event();
            e1.SetValue(0, 5);
            e1.SetValue(1, 6);
            e1.SetValue(2, 3);
            e1.SetValue(3, 7);
            e1.SetValue(4, 8);
            e1.SetValue(5, 4);
            e1.SetValue(6, 9);

            e2.SetValue(0, 1);
            e2.SetValue(1, 10);
            e2.SetValue(2, 2);
            e2.SetValue(3, 4);
            e2.SetValue(4, 5);
            e2.SetValue(5, 2);
            e2.SetValue(6, 6);
            e2.VIP = new Person("Vendeg Piroska", 30);

            e1.Write();
            e2.Write();

            // Event teszt: másoló konstruktor
            Console.WriteLine();
            //	Event copy = new Event(e2);
            //	copy.Write();
            //	copy.SetValue(4,123);
            //	copy.SetValue(1,222);
            //	copy.Write();

            //// Event teszt: legjobb nap
            Console.WriteLine();
            //	e1.BestDay();
            //	e2.BestDay();

            //// NumberLine teszt: kisebb átlag
            Console.WriteLine();
            //	Console.Write("Atlag osszehasonlitas: nl1 vs nl2: ");
            //	LowerAverage(nl1,nl2);
            //	Console.Write("Atlag osszehasonlitas: nl2 vs e1: ");
            //	LowerAverage(nl2,e1);
            //	Console.Write("Atlag osszehasonlitas: e1 vs e2: ");
            //	LowerAverage(e1,e2);
            //	Console.Write("Atlag osszehasonlitas: e2 vs nl1: ");
            //	LowerAverage(e2,nl1);
            //	Console.Write("Atlag osszehasonlitas: nl1 vs e1: ");
            //	LowerAverage(nl1,e1);
            //	Console.Write("Atlag osszehasonlitas: nl2 vs e2: ");
            //	LowerAverage(nl2,e2);

            Console.ReadKey();
        }

        static void WriteNumberLine(NumberLine numberLine)
        {
            for (int i = 0; i < numberLine.Array.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write($"{numberLine.GetValue(i)}");
            }
            Console.WriteLine();
        }
    }
}