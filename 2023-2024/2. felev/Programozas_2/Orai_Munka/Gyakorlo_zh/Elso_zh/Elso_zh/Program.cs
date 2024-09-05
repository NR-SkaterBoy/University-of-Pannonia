#region MegoldottFeladatok
#define PART1 // MerkozesSorozat osztaly (2 pont)
#define PART2 // MerkozesSorozat.UjEredmeny() (1 pont)
#define PART3 // MerkozesSorozat.NyertesCsapat() (2 pont)
#define PART4 // MerkozesSorozat.Kiir() (2 pont)
#define PART5 // MerkozesSorozat.Kiir() opcionalis parameterrel (1 pont)
#define PART6 // MerkozesSorozat statikus adattag (2 pont)
#endregion

using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace Kiszh1Pelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if PART1
            using (TestGuard tg = new TestGuard("PART1")) {
                System.Console.WriteLine("MerkozesSorozat a Merkozes gyerekosztalya: {0}", typeof(MerkozesSorozat).IsSubclassOf(typeof(Merkozes)) ? "IGEN" : "NEM");
                MerkozesSorozat sorozat1 = new MerkozesSorozat("Ball Chasers", "Football Club FC", 5);
                Console.WriteLine($"{sorozat1.HazaiCsapat} vs {sorozat1.VendegCsapat}");
            }//
#endif
#if PART2
            using (TestGuard tg = new TestGuard("PART2"))
            {
                MerkozesSorozat sorozat1 = new MerkozesSorozat("Ball Chasers", "Football Club FC", 5);
                MerkozesSorozat sorozat2 = new MerkozesSorozat("Alpha Bet Club", "Team Shaolin", 8);
                sorozat1.UjEredmeny(0, 1);
                sorozat1.UjEredmeny(1, 2);
                sorozat1.UjEredmeny(2, 0);
                sorozat1.UjEredmeny(3, 1);
                sorozat1.UjEredmeny(4, 1);
                sorozat2.UjEredmeny(1, 2);
                sorozat2.UjEredmeny(3, 2);
                sorozat2.UjEredmeny(4, 2);
                sorozat2.UjEredmeny(7, 1);
                Console.WriteLine("Latszolag jo");
            }
#endif
#if PART3
            using (TestGuard tg = new TestGuard("PART3")) {
                MerkozesSorozat sorozat1 = new MerkozesSorozat("Ball Chasers", "Football Club FC", 5);
                MerkozesSorozat sorozat2 = new MerkozesSorozat("Alpha Bet Club", "Team Shaolin", 8);
                sorozat1.UjEredmeny(0, 1);
                sorozat1.UjEredmeny(1, 2);
                sorozat1.UjEredmeny(2, 0);
                sorozat1.UjEredmeny(3, 1);
                sorozat1.UjEredmeny(4, 1);
                sorozat2.UjEredmeny(1, 2);
                sorozat2.UjEredmeny(3, 2);
                sorozat2.UjEredmeny(4, 2);
                sorozat2.UjEredmeny(7, 1);
                Console.WriteLine(sorozat1.NyertesCsapat());
                Console.WriteLine(sorozat2.NyertesCsapat());
                sorozat1.UjEredmeny(3, 2);
                sorozat2.UjEredmeny(4, 0);
                sorozat2.UjEredmeny(6, 1);
                Console.WriteLine(sorozat1.NyertesCsapat());
                Console.WriteLine(sorozat2.NyertesCsapat());
                sorozat1.UjEredmeny(2, 2);
                sorozat2.UjEredmeny(5, 1);
                Console.WriteLine(sorozat1.NyertesCsapat());
                Console.WriteLine(sorozat2.NyertesCsapat());
            }//
#endif
#if PART4
            using (TestGuard tg = new TestGuard("PART4"))
            {
                MerkozesSorozat sorozat1 = new MerkozesSorozat("Ball Chasers", "Football Club FC", 5);
                MerkozesSorozat sorozat2 = new MerkozesSorozat("Alpha Bet Club", "Team Shaolin", 8);
                sorozat1.UjEredmeny(0, 2);
                sorozat1.UjEredmeny(1, 1);
                sorozat1.UjEredmeny(2, 0);
                sorozat1.UjEredmeny(3, 2);
                sorozat1.UjEredmeny(4, 0);
                sorozat2.UjEredmeny(4, 0);
                sorozat2.UjEredmeny(5, 1);
                sorozat2.UjEredmeny(2, 2);
                sorozat2.UjEredmeny(6, 2);
                sorozat1.Kiir();
                Console.WriteLine();
                sorozat2.Kiir();
            }//
#endif
#if PART5
            using (TestGuard tg = new TestGuard("PART5"))
            {
                MerkozesSorozat sorozat1 = new MerkozesSorozat("Ball Chasers", "Football Club FC", 5);
                MerkozesSorozat sorozat2 = new MerkozesSorozat("Alpha Bet Club", "Team Shaolin", 8);
                sorozat1.UjEredmeny(0, 2);
                sorozat1.UjEredmeny(1, 1);
                sorozat1.UjEredmeny(2, 0);
                sorozat1.UjEredmeny(3, 2);
                sorozat1.UjEredmeny(4, 0);
                sorozat2.UjEredmeny(4, 0);
                sorozat2.UjEredmeny(5, 1);
                sorozat2.UjEredmeny(2, 2);
                sorozat2.UjEredmeny(6, 2);
                sorozat1.Kiir(true);
                Console.WriteLine();
                sorozat2.Kiir(true);
            }//
#endif
#if PART6
            using (TestGuard tg = new TestGuard("PART6"))
            {
                MerkozesSorozat sorozat1 = new MerkozesSorozat("Ball Chasers", "Football Club FC", 5);
                MerkozesSorozat sorozat2 = new MerkozesSorozat("Alpha Bet Club", "Team Shaolin", 8);
                Console.WriteLine(MerkozesSorozat.RosszIndexek);
                sorozat1.UjEredmeny(4, 2);
                Console.WriteLine(MerkozesSorozat.RosszIndexek);
                sorozat1.UjEredmeny(-1, 1);
                Console.WriteLine(MerkozesSorozat.RosszIndexek);
                sorozat1.UjEredmeny(1, 0);
                Console.WriteLine(MerkozesSorozat.RosszIndexek);
                sorozat2.UjEredmeny(5, 0);
                Console.WriteLine(MerkozesSorozat.RosszIndexek);
                sorozat2.UjEredmeny(2, 1);
                Console.WriteLine(MerkozesSorozat.RosszIndexek);
                sorozat2.UjEredmeny(5, 2);
                Console.WriteLine(MerkozesSorozat.RosszIndexek);
                sorozat2.UjEredmeny(-5, 1);
                Console.WriteLine(MerkozesSorozat.RosszIndexek);
                sorozat2.UjEredmeny(0, 2);
                Console.WriteLine(MerkozesSorozat.RosszIndexek);
                sorozat2.UjEredmeny(8, 2);
                Console.WriteLine(MerkozesSorozat.RosszIndexek);
            }//
#endif

            Console.ReadKey();
        }
    }
    public class TestGuard : IDisposable
    {
        string _name;
        public TestGuard(string name) { _name = name; Console.WriteLine($"\n\n----START OF {_name}----"); }
        public void Dispose() { Console.WriteLine($"----END OF {_name}----"); GC.SuppressFinalize(this); }
    }
}
