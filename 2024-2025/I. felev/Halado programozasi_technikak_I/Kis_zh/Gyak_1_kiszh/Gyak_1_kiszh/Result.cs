using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gyak_1_kiszh
{
    internal class Result
    {
        public string Group { get; set; }
        public int Score { get; set; }
        public int WorkTime { get; set; }

        public static List<Result> Results { get; set; } = new List<Result>();

        public static void LoadDataFromJson(string jsonPath)
        {
            var results =
                JsonSerializer.Deserialize<List<Result>>(File.ReadAllText(jsonPath));
            if (results != null)
                Results.AddRange(results);
            Console.WriteLine("Scores loaded");
        }


        public static void test(int s, int t)
        {
            List<Result> results = Results;
            List<Result> goodForUs = new List<Result>();

            foreach (var e in results)
            {
                if (e.Score >= s && e.WorkTime <= t)
                {
                    goodForUs.Add(e);
                }
            }
             Console.WriteLine($"{goodForUs.First().Group} {goodForUs.First().Score} {goodForUs.First().WorkTime}");
        }

        public static void FindGroupByScoreAndTime(int score, int time)
        {
            Console.WriteLine(
                $"Score with at least {score} points under {time} minutes:");
            List<Result> results = Results;

            var matched =
                results.Where(x => x.Score >= score && x.WorkTime <= time).ToList();

            var goodForUs =
                matched.GroupBy(g => g.Group)
                    .Select(g => new
                    {
                        Group = g.Key,
                        AVGScore = g.First().Score,
                        Time = g.First().WorkTime
                    });

            if (goodForUs.Any())
            {
                foreach (var e in goodForUs)
                {
                    Console.WriteLine($"{e.Group}, {e.Time}");
                }
                Console.WriteLine(
                    $"\tGroup: {goodForUs.First().Group}, Score: {goodForUs.First().AVGScore}, Time: {goodForUs.First().Time}");
            }
            else
            {
                Console.WriteLine(
                    "\tError: could not find score: There is no score with required values");
            }
        }

        public static void test2()
        {
            List<Result> results = Results;
            Dictionary<string, List<int>> csp = new Dictionary<string, List<int>>();

            foreach (var e in results)
            {
                if(!csp.ContainsKey(e.Group))
                    csp.Add(e.Group, new List<int>());

                csp[e.Group].Add(e.Score);
            }

            foreach (var item in csp)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Average()}");
            }
        }

        public static void AvaragePoint()
        {
            List<Result> results = Results;

            var groups = results.GroupBy(g => g.Group)
                             .ToDictionary(g => g.Key, g => g.Average(x => x.Score));
            // Console.WriteLine(groups.Count);
            foreach (var gData in groups)
            {
                Console.WriteLine($"Average of group {gData.Key} : {gData.Value}");
            }
        }

        public int MarkByScore(int score)
        {
            if (score < 60)
                return 1;
            if (score < 70)
                return 2;
            if (score < 80)
                return 3;
            if (score < 90)
                return 4;
            return 5;
        }

        public static void FrequentlyMark()
        {
            List<Result> results = Results;
            var instance = new Result();

            var groups =
                results.GroupBy(g => g.Group)
                    .Select(g => new
                    {
                        Group = g.Key,
                        Marks = g.Select(x => instance.MarkByScore(x.Score)).ToList(),
                        TestCount = g.Count()
                    });

            foreach (var group in groups)
            {
                var markCounts =
                    group.Marks.GroupBy(m => m)
                        .Select(mc => new { Mark = mc.Key, Count = mc.Count() })
                        .ToList();

                var maxCount = markCounts.Max(mc => mc.Count);
                var mostCommonMarks = markCounts.Where(mc => mc.Count == maxCount)
                                          .Select(mc => mc.Mark)
                                          .ToList();

                Console.WriteLine(
                    $"Most common grades in group {group.Group} with {group.TestCount} tests: {string.Join(", ", mostCommonMarks)}");
            }
        }
    }
}
