#region MegoldottFeladatok
#define PART1  // LimitedStorage osztaly (2 pont)
#define PART2  // LimitedStorage.Add() (2 pont)
#define PART3  // LimitedStorage.Item() (1 pont)
#define PART3A // LimitedStorage.Item() ellenorzessel (1 pont)
#define PART4  // LimitedStorage.Extend() (2 pont)
#define PART5  // Extra.LoadStorageList() (2 pont)
#endregion

using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using System.Threading;


namespace Kiszh3Pelda
{
    class BaseClass
    {
        protected int v;
        public BaseClass(int v) { this.v = v; }
        public override string ToString() { return $"BASE: {v}"; }
    }
    class DerivedClass1 : BaseClass
    {
        protected int w;
        public DerivedClass1(int v, int w) : base(v) { this.w = w; }
        public override string ToString() { return $"DERIVED1: {v}, {w}"; }
    }
    class DerivedClass2 : DerivedClass1
    {
        protected int x;
        public DerivedClass2(int v, int w, int x) : base(v, w) { this.x = x; }
        public override string ToString() { return $"DERIVED2: {v}, {w}, {x}"; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string CultureName = Thread.CurrentThread.CurrentCulture.Name;
            CultureInfo ci = new CultureInfo(CultureName);
            if (ci.NumberFormat.NumberDecimalSeparator != ".")
            {
                // Forcing use of decimal separator for numerical values
                ci.NumberFormat.NumberDecimalSeparator = ".";
                Thread.CurrentThread.CurrentCulture = ci;
            }
#if PART1
            using (TestGuard tg = new TestGuard("PART1"))
            {
                LimitedStorage<int> ints = new LimitedStorage<int>(6);
                LimitedStorage<double> doubles = new LimitedStorage<double>(10);
                LimitedStorage<string> strings = new LimitedStorage<string>(3);
                Console.WriteLine(ints.MaxSize);
                Console.WriteLine(doubles.MaxSize);
                Console.WriteLine(strings.MaxSize);
            }//
#endif
#if PART2
            using (TestGuard tg = new TestGuard("PART2"))
            {
                LimitedStorage<int> ints = new LimitedStorage<int>(6);
                LimitedStorage<double> doubles = new LimitedStorage<double>(10);
                LimitedStorage<string> strings = new LimitedStorage<string>(3);
                ints.Add(6);
                ints.Add(5);
                ints.Add(4);
                ints.Add(2);
                doubles.Add(4.6);
                doubles.Add(1.6);
                doubles.Add(6.4);
                doubles.Add(8.7);
                doubles.Add(1.3);
                strings.Add("alma");
                strings.Add("korte");
                strings.Add("barack");
                strings.Add("szilva");
                strings.Add("mandarin");
                Console.WriteLine($"ints: {ints.Size} / {ints.MaxSize}");
                Console.WriteLine($"doubles: {doubles.Size} / {doubles.MaxSize}");
                Console.WriteLine($"strings: {strings.Size} / {strings.MaxSize}");
            }
#endif
#if PART3
            using (TestGuard tg = new TestGuard("PART3"))
            {
                LimitedStorage<int> ints = new LimitedStorage<int>(6);
                LimitedStorage<double> doubles = new LimitedStorage<double>(10);
                LimitedStorage<string> strings = new LimitedStorage<string>(3);
                ints.Add(6);
                ints.Add(5);
                ints.Add(4);
                ints.Add(2);
                doubles.Add(4.6);
                doubles.Add(1.6);
                doubles.Add(6.4);
                doubles.Add(8.7);
                doubles.Add(1.3);
                strings.Add("alma");
                strings.Add("korte");
                strings.Add("barack");
                strings.Add("szilva");
                strings.Add("mandarin");
                Console.WriteLine("#ints#");
                for (int i = 0; i < ints.Size; i++)
                { Console.WriteLine(ints.Item(i)); }
                Console.WriteLine("#doubles#");
                for (int i = 0; i < doubles.Size; i++)
                { Console.WriteLine(doubles.Item(i)); }
                Console.WriteLine("#strings#");
                for (int i = 0; i < strings.Size; i++)
                { Console.WriteLine(strings.Item(i)); }
            }//
#endif
#if PART3A
            using (TestGuard tg = new TestGuard("PART3A"))
            {
                LimitedStorage<int> ints = new LimitedStorage<int>(6);
                LimitedStorage<double> doubles = new LimitedStorage<double>(10);
                LimitedStorage<string> strings = new LimitedStorage<string>(3);
                ints.Add(6);
                ints.Add(5);
                ints.Add(4);
                ints.Add(2);
                doubles.Add(4.6);
                doubles.Add(1.6);
                doubles.Add(6.4);
                doubles.Add(8.7);
                doubles.Add(1.3);
                strings.Add("alma");
                strings.Add("korte");
                strings.Add("barack");
                strings.Add("szilva");
                strings.Add("mandarin");
                Console.WriteLine($"ints.Item(0) = {ints.Item(0)}");
                Console.WriteLine($"ints.Item(3) = {ints.Item(3)}");
                Console.WriteLine($"ints.Item(4) = {ints.Item(4)}");
                Console.WriteLine($"ints.Item(8) = {ints.Item(8)}");
                Console.WriteLine($"doubles.Item(0) = {doubles.Item(0)}");
                Console.WriteLine($"doubles.Item(4) = {doubles.Item(4)}");
                Console.WriteLine($"doubles.Item(5) = {doubles.Item(5)}");
                Console.WriteLine($"doubles.Item(10) = {doubles.Item(10)}");
                Console.WriteLine($"strings.Item(0) = \"{strings.Item(0)}\"");
                Console.WriteLine($"strings.Item(2) = \"{strings.Item(2)}\"");
                Console.WriteLine($"strings.Item(-1) = \"{strings.Item(-1)}\"");
                Console.WriteLine($"strings.Item(15) = \"{strings.Item(15)}\"");
            }//
#endif
#if PART4
            using (TestGuard tg = new TestGuard("PART4"))
            {

                LimitedStorage<int> ints = new LimitedStorage<int>(6);
                LimitedStorage<double> doubles = new LimitedStorage<double>(10);
                LimitedStorage<BaseClass> classes = new LimitedStorage<BaseClass>(25);
                ints.Add(6);
                ints.Add(5);
                ints.Add(4);
                ints.Add(2);
                doubles.Add(4.6);
                doubles.Add(1.6);
                doubles.Add(6.4);
                doubles.Add(8.7);
                doubles.Add(1.3);
                classes.Add(new BaseClass(2));
                classes.Add(new BaseClass(5));
                classes.Add(new BaseClass(6));

                ints.Extend(new List<int> { 2, 3, 5, 1, 5 });
                doubles.Extend(new List<double> { 2.4, 2.6, 8.3 });
                classes.Extend(new List<BaseClass> { new BaseClass(1), new BaseClass(2), new BaseClass(9) });
                classes.Extend(new List<DerivedClass1> { new DerivedClass1(1, 2), new DerivedClass1(3, 4), new DerivedClass1(5, 6) });
                classes.Extend(new List<DerivedClass2> { new DerivedClass2(1, 2, 3), new DerivedClass2(4, 5, 6), new DerivedClass2(7, 8, 9) });

                Console.WriteLine($"ints: {ints.Size} / {ints.MaxSize}");
                for (int i = 0; i < ints.Size; i++)
                { Console.WriteLine(ints.Item(i)); }
                Console.WriteLine($"doubles: {doubles.Size} / {doubles.MaxSize}");
                for (int i = 0; i < doubles.Size; i++)
                { Console.WriteLine(doubles.Item(i)); }
                Console.WriteLine($"classes: {classes.Size} / {classes.MaxSize}");
                for (int i = 0; i < classes.Size; i++)
                { Console.WriteLine(classes.Item(i)); }
            }//
#endif
#if PART5
            using (TestGuard tg = new TestGuard("PART5"))
            {
                List<LimitedStorage<double>> test1 = Extra.LoadStorageList("test1.txt");
                List<LimitedStorage<double>> test2 = Extra.LoadStorageList("test2.txt");
                Console.WriteLine("#test1#");
                foreach (var store1 in test1)
                {
                    for (int i = 0; i < store1.Size; i++)
                    {
                        Console.Write(store1.Item(i));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("#test2#");
                foreach (var store2 in test2)
                {
                    for (int i = 0; i < store2.Size; i++)
                    {
                        Console.Write(store2.Item(i) + " ");
                    }
                    Console.WriteLine();
                }
            }//
#endif
        }
    }
    public class TestGuard : IDisposable
    {
        string _name;
        public TestGuard(string name) { _name = name; Console.WriteLine($"\n\n----START OF {_name}----"); }
        public void Dispose() { Console.WriteLine($"----END OF {_name}----"); GC.SuppressFinalize(this); }
    }
}
