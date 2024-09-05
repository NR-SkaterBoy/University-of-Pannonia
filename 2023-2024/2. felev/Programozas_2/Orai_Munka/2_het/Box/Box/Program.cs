using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    internal class Program
    {
        static Box[] BekerAdat(int boxes)
        {
            Box[] result = new Box[boxes];
            for (int i = 0; i < boxes; i++)
            {
                Console.WriteLine($"Az {i+1} doboz adataitt add meg: ");
                Console.Write("Doboz neve: ");
                string name = Console.ReadLine();
                Console.Write("Doboz szelessege: ");
                int width = int.Parse(Console.ReadLine());
                Console.Write("Doboz hosszusaga: ");
                int height = int.Parse(Console.ReadLine());
                Console.Write("Doboz magassaga: ");
                int length = int.Parse(Console.ReadLine());
                result[i] = new Box(name, width, height, length);
            }

            return result;
        }

        public void KiirDoboz(Box[] boxes)
        {
            Console.WriteLine("A dobozok adatai:");
            foreach (var e in boxes)
            {
                Console.WriteLine(e.FormazottSzoveg());
                Console.WriteLine($"A: {e.Felszin()}, V: {e.Terfogat()}");
            }
        }

        static void BeilleszthetoDobozok(Box[] boxes, int hossz = 2, int szelesseg = 2, int magassag = 2)
        {
            Console.WriteLine($"Rekesz mérete: h: {hossz}, sz: {szelesseg}, m: {magassag}");
            foreach (Box doboz in boxes)
            {
                if (doboz.Belefer(szelesseg, magassag, hossz))
                {
                    Console.WriteLine($"- {doboz.Name}");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Hany doboz adatait taroljam: ");
            int boxes = int.Parse(Console.ReadLine());
            Box[] box = BekerAdat(boxes);

            #region Belefer
            Box doboz1 = new Box("Doboz1", 10, 15, 20);
            Box doboz2 = new Box("Doboz2", 5, 10, 15);
            Box doboz3 = new Box("Doboz3", 12, 18, 24);

            Console.WriteLine($"{doboz1.FormazottSzoveg()} befogadja a {doboz2.FormazottSzoveg()} dobozt? {doboz1.Belefer(doboz2)}");
            Console.WriteLine($"{doboz1.FormazottSzoveg()} befogadja a {doboz3.FormazottSzoveg()} dobozt? {doboz1.Belefer(doboz3)}");
            #endregion

            #region BeilleszthetoDobozok
            BeilleszthetoDobozok(box, 3, 4, 3);
            BeilleszthetoDobozok(box, 4, 3);
            BeilleszthetoDobozok(box, 3, 4);
            BeilleszthetoDobozok(box, 3, 3);
            #endregion

            Console.ReadKey();
        }
    }
}
