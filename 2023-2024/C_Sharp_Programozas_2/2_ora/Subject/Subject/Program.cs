using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject
{
    internal class Program
    {

        static void KiirAdatok(Subject[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i].KiirAdat());
                Console.WriteLine($"{s[i].Name} átlaga: {s[i].Atltag()}");
            }
        }

        static void Legmagasabb(Subject[] s)
        {
            int idx = 0;
            for(int i = 0; i < s.Length;i++) {
                if (s[i].Atltag() > s[idx].Atltag())
                {
                    idx = i;
                }
            }

            Console.WriteLine($"A legmagasabb atlag: {s[idx].Atltag()}, tantargy: {s[idx].Name}");
        }

        static void AddNegyes(Subject[] s, uint jegy) {
            for (int i = 0; i < s.Length; i++)
            {
                s[i].AddUjJegy(jegy);
            }
        }
        
        static void JegyeketSzamol(Subject[] s)
        {
            Console.WriteLine("Tantargy és jegyek szama:");
            foreach (var e in s)
            {
                Console.WriteLine(e.Name);
                for (uint i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"\t{i} jegybol {e.szamolJegy(i)}db van");
                }
            }
        }

        static void Main(string[] args)
        {
            #region Fixen tarolt adatok
            Subject[] subject = new Subject[3];
            subject[0] = new Subject("Matek", new uint[] {1, 2, 3, 4, 5});
            subject[1] = new Subject("Magyar", new uint[] {2, 2, 2, 4, 3});
            subject[2] = new Subject("Angol", new uint[] {5, 5, 3, 4, 5, 5, 1});
            #endregion

            KiirAdatok(subject);
            Legmagasabb(subject);
            AddNegyes(subject, 4);
            KiirAdatok(subject);
            JegyeketSzamol(subject);


            Console.ReadKey();
        }
    }
}
