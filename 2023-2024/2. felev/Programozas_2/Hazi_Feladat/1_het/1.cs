/**
 * Kérd be a mellékelt programban létrehozott változók értékeit (olyan sorrendben, ahogy létrehozzuk őket),
 * majd jelenítsd is meg őket, mindet külön sorba!
 *
 * Input:   5, 6, 2.4, alma
 * Output:  5, 6, 2.4, alma
 */

using System;

namespace HomeWork
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b;
            double c;
            string s;

            //  ======================================================
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            s = Console.ReadLine();

            Console.WriteLine($"{a}\n{b}\n{c}\n{s}");

            //  ======================================================
        }
    }
}