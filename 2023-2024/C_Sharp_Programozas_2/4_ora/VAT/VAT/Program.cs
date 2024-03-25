using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAT
{
    internal class Program
    {

        static void Write(Goods g)
        {
            Console.WriteLine($"Név: {g.Name}, nettó ára: {g.NetPrice} bruttó ára: {g.GrossPrice()}");
        }

        static void Main(string[] args)
        {
            Goods g1 = new Goods("elem", 2000);
            Goods g2 = new Goods("lámpa", 12400);
            Goods g3 = new Goods("gyufa", 50);

            Console.WriteLine($"{g1.Name} nettó ára: {g1.NetPrice}");
            Console.WriteLine($"{g2.Name} nettó ára: {g2.NetPrice}");
            Console.WriteLine($"{g3.Name} nettó ára: {g3.NetPrice}");

            // GrossPrice(bruttó ár) függvény
            Console.WriteLine();
            Console.WriteLine("GrossPrice függvény");
            Console.WriteLine($"{g1.Name} nettó ára: {g1.NetPrice}, bruttó ára: {g1.GrossPrice()}"); // brutto: 2550
            Console.WriteLine($"{g2.Name} nettó ára: {g2.NetPrice}, bruttó ára: {g2.GrossPrice()}"); // brutto: 15810
            Console.WriteLine($"{g3.Name} nettó ára: {g3.NetPrice}, bruttó ára: {g3.GrossPrice()}"); // brutto: 64

            // ÁFA setter és getter
            Console.WriteLine();
            Console.WriteLine("ÁFA setter-getter");
            Console.WriteLine($"Az ÁFA jelenlegi értéke: {Goods.VAT}");
            Goods.VAT = 25;
            Console.WriteLine($"Az ÁFA új értéke: {Goods.VAT}");
            Console.WriteLine($"{g1.Name} nettó ára: {g1.NetPrice}, bruttó ára: {g1.GrossPrice()}"); // brutto: 2500
            Console.WriteLine($"{g2.Name} nettó ára: {g2.NetPrice}, bruttó ára: {g2.GrossPrice()}"); // brutto: 15500
            Console.WriteLine($"{g3.Name} nettó ára: {g3.NetPrice}, bruttó ára: {g3.GrossPrice()}"); // brutto: 62

            // Write függvény teszt
            Console.WriteLine();
            Console.WriteLine("Write függvény");
            Write(g1);
            Write(g2);
            Write(g3);

            // Food teszt: létrehozás
            Console.WriteLine();
            Console.WriteLine("Food teszt");
            Food f1 = new Food("tej", 200, new DateTime(2024, 3, 28));
            Food f2 = new Food("kenyér", 185, new DateTime(2024, 3, 25));
            Food f3 = new Food("sajt", 1500, new DateTime(2024, 4, 6));
            Console.WriteLine($"{f1.Name} lejár: {f1.ExpiryDate.ToString("yyyy. MM. dd")}");
            Console.WriteLine($"{f2.Name} lejár: {f2.ExpiryDate.ToString("yyyy. MM. dd")}");
            Console.WriteLine($"{f3.Name} lejár: {f3.ExpiryDate.ToString("yyyy. MM. dd")}");

            // Food teszt: ÁFA értékek
            Console.WriteLine();
            Console.WriteLine("ÁFA értékek");
            Console.WriteLine($"Goods ÁFA = {Goods.VAT}");
            Console.WriteLine($"Food ÁFA = {Food.VAT}");
            Goods.VAT = 26;
            Food.VAT = 20;
            Console.WriteLine($"Goods ÁFA = {Goods.VAT}");
            Console.WriteLine($"Food ÁFA = {Food.VAT}");

            // Food teszt: bruttoAr függvény
            Console.WriteLine();
            Console.WriteLine("Food bruttó ár");
            Console.WriteLine($"{f1.Name} lejár: {f1.ExpiryDate.ToString("yyyy. MM. dd")}, nettó: {f1.NetPrice}, bruttó: {f1.GrossPrice()}"); // brutto: 240
            Console.WriteLine($"{f2.Name} lejár: {f2.ExpiryDate.ToString("yyyy. MM. dd")}, nettó: {f2.NetPrice}, bruttó: {f2.GrossPrice()}"); // brutto: 222
            Console.WriteLine($"{f3.Name} lejár: {f3.ExpiryDate.ToString("yyyy. MM. dd")}, nettó: {f3.NetPrice}, bruttó: {f3.GrossPrice()}"); // brutto: 1800

            // kiir függvény teszt a Foodra
            // Figyeljük meg, hogy mivel a kiir paramétere Goods típusú, ezért hiába adunk át neki Food típusú objektumot,
            // Goods típusúként kezeli. Ennek a következménye, hogy a Goods osztály bruttó függvényével dolgozik,
            // ami a Food osztály ÁFA értékével számol.
            Console.WriteLine();
            Console.WriteLine("Write függvény Food");
            Write(f1);
            Write(f2);
            Write(f3);


            Console.ReadKey();
        }
    }
}