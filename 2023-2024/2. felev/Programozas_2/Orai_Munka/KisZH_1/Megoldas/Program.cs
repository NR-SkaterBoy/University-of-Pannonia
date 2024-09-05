#region MegoldottFeladatok
#define PART1 // FootballCompetition osztaly (2 pont)
#define PART2 // FootballCompetition.SetTeam() (1 pont)
#define PART3 // FootballCompetition.Print() (2 pont)
#define PART4 // FootballCompetition statikus adattag (1 pont)
#define PART5 // FootballCompetition.WhoNeedsMoreMatches() (2 pont)
#define PART6 // FootballCompetition.BestTeam() (2 pont)
#endregion

using Kiszh1H14;
using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace Kiszh1Pelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team[] teams1 = { new Team("Local FC", 3, 1), new Team("University FC", 5, 0), new Team("Old Timers", 2, 9) };
            Team[] teams2 = { new Team("Alpha Bet Club", 4, 0), new Team("Ball Chasers", 0, 4), new Team("Football Club FC", 3, 2), new Team("Team Shaolin", 2, 7), new Team("Team Titans", 6, 2), new Team("Ball Benders", 1, 1), new Team("Fortress Team", 2, 5), new Team("Dragon Football", 4, 1) };
#if PART1
            using (TestGuard tg = new TestGuard("PART1")) {
                System.Console.WriteLine("FootballCompetition a Competition gyerekosztalya: {0}", typeof(FootballCompetition).IsSubclassOf(typeof(Competition)) ? "IGEN" : "NEM");
                FootballCompetition fc1 = new FootballCompetition("Local Championship", new DateTime(2024,1,15), new DateTime(2024,4,10), 3);
                Console.WriteLine($"{fc1.Name} : from {fc1.StartDate.ToString("yyyy.MM.dd")} to {fc1.EndDate.ToString("yyyy.MM.dd")}");
            }//
#endif
#if PART2
            using (TestGuard tg = new TestGuard("PART2"))
            {
                FootballCompetition fc1 = new FootballCompetition("Local Championship", new DateTime(2024, 1, 15), new DateTime(2024, 4, 10), 3);
                FootballCompetition fc2 = new FootballCompetition("National Championship", new DateTime(2024, 2, 1), new DateTime(2024, 6, 30), 8);
                for (int i=0; i<teams1.Length; i++)
                { fc1.SetTeam(i, teams1[i]); }
                for (int i = 0; i < teams2.Length; i++)
                { fc2.SetTeam(i, teams2[i]); }
                Console.WriteLine("Latszolag jo");
            }
#endif
#if PART3
            using (TestGuard tg = new TestGuard("PART3")) {
                FootballCompetition fc1 = new FootballCompetition("Local Championship", new DateTime(2024, 1, 15), new DateTime(2024, 4, 10), 3);
                FootballCompetition fc2 = new FootballCompetition("National Championship", new DateTime(2024, 2, 1), new DateTime(2024, 6, 30), 8);
                for (int i = 0; i < teams1.Length; i++)
                { fc1.SetTeam(i, teams1[i]); }
                for (int i = 0; i < teams2.Length; i++)
                { fc2.SetTeam(i, teams2[i]); }
                Console.WriteLine("##fc1##");
                fc1.Print();
                Console.WriteLine("##fc2##");
                fc2.Print();
            }//
#endif
#if PART4
            using (TestGuard tg = new TestGuard("PART4"))
            {
                if (typeof(FootballCompetition).GetProperty("RequiredMatches") == null)
                { Console.WriteLine("ERROR: RequiredMatches is not a property!"); }
                Console.WriteLine(FootballCompetition.RequiredMatches);
                FootballCompetition.RequiredMatches = 2;
                Console.WriteLine(FootballCompetition.RequiredMatches);
                FootballCompetition.RequiredMatches = 10;
                Console.WriteLine(FootballCompetition.RequiredMatches);
                FootballCompetition.RequiredMatches = 5;
                Console.WriteLine(FootballCompetition.RequiredMatches);
            }//
#endif
#if PART5
            using (TestGuard tg = new TestGuard("PART5"))
            {
                FootballCompetition fc1 = new FootballCompetition("Local Championship", new DateTime(2024, 1, 15), new DateTime(2024, 4, 10), 3);
                FootballCompetition fc2 = new FootballCompetition("National Championship", new DateTime(2024, 2, 1), new DateTime(2024, 6, 30), 8);
                for (int i = 0; i < teams1.Length; i++)
                { fc1.SetTeam(i, teams1[i]); }
                for (int i = 0; i < teams2.Length; i++)
                { fc2.SetTeam(i, teams2[i]); }
                Console.WriteLine($"## With {FootballCompetition.RequiredMatches} required matches: ##");
                fc1.WhoNeedsMoreMatches();
                fc2.WhoNeedsMoreMatches();
                FootballCompetition.RequiredMatches = 8;
                Console.WriteLine($"## With {FootballCompetition.RequiredMatches} required matches: ##");
                fc1.WhoNeedsMoreMatches();
                fc2.WhoNeedsMoreMatches();
                FootballCompetition.RequiredMatches = 3;
                Console.WriteLine($"## With {FootballCompetition.RequiredMatches} required matches: ##");
                fc1.WhoNeedsMoreMatches();
                fc2.WhoNeedsMoreMatches();
            }//
#endif
#if PART6
            using (TestGuard tg = new TestGuard("PART6"))
            {
                FootballCompetition fc1 = new FootballCompetition("Local Championship", new DateTime(2024, 1, 15), new DateTime(2024, 4, 10), 3);
                FootballCompetition fc2 = new FootballCompetition("National Championship", new DateTime(2024, 2, 1), new DateTime(2024, 6, 30), 8);
                for (int i = 0; i < teams1.Length; i++)
                { fc1.SetTeam(i, teams1[i]); }
                for (int i = 0; i < teams2.Length; i++)
                { fc2.SetTeam(i, teams2[i]); }
                Team bt1 = fc1.BestTeam();
                Team bt2 = fc2.BestTeam();
                Console.WriteLine($"Best team of {fc1.Name} : {bt1.Name}");
                Console.WriteLine($"Best team of {fc2.Name} : {bt2.Name}");
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
