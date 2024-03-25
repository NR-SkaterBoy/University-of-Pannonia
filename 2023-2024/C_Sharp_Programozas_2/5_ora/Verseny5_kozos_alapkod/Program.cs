namespace Verseny5_kozos
{
    internal class Program
    {
        static void KiirProbalkozasList(List<Probalkozas> probalkozasok)
        {
            for (int i = 0; i < probalkozasok.Count; i++)
            {
                Console.WriteLine($"Név: {probalkozasok[i].Nev} Távolság: {probalkozasok[i].Tavolsag} Érvényes: {probalkozasok[i].Ervenyes}");
            }
        }

        static void Main(string[] args)
        {  
            Console.WriteLine("Main függvény eleje");

            //{
            //    List<Probalkozas> probalkozas = new List<Probalkozas>();
            //    probalkozas.Add(new Probalkozas("Sandor", 29.9, true));
            //    KiirProbalkozasList(probalkozas)
            //}
            //
            // Név: Sandor Távolság: 29.9 Érvényes: True
            // Név: Jozsef Távolság: 31.8 Érvényes: False
            // Név: Benedek Távolság: 2.7 Érvényes: False

            // konstruktor teszt (egyelore nincs output)
            Verseny v1 = new Verseny("verseny1.txt");
            Verseny v2 = v1;

            // Kiir() 1. verzio teszt
            v1.Kiir();
            Console.WriteLine();
            // Verseny1
            // Anita 35.91 True
            // Bea 40.17 True
            // Csilla 39.93 True
            // Diana 36.98 True
            // Emma 37.11 True
            // Emma 39.22 False
            // Diana 37.12 True
            // Anita 38.88 False
            // Anita 35.92 True
            // Csilla 38.5 False

            //// Kiir() 2. verzio teszt (lasd a keletkezett fajl tartalmat!)
            //v2.Kiir("verseny1-masolat1.txt");

            //// Uj() teszt
            //v1.Uj("Diana", 40.31, false);
            //v1.Uj("Diana", 40.29, true);
            //v1.Kiir();
            //Console.WriteLine();
            // Verseny1
            // Anita 35.91 True
            // Bea 40.17 True
            // Csilla 39.93 True
            // Diana 36.98 True
            // Emma 37.11 True
            // Emma 39.22 False
            // Diana 37.12 True
            // Anita 38.88 False
            // Anita 35.92 True
            // Csilla 38.5 False
            // Diana 40.31 False
            // Diana 40.29 True

            //    // ErvenyesDobasok() teszt
            //    {
            //        Console.WriteLine("Ervenyes dobasok listaja:");
            //        // itt kerdezd le es ird ki az ervenyes dobasokat:
            //        // (...)
            //        Console.WriteLine();
            //    }
            //    // Ervenyes dobasok listaja:
            //    // 35.91 40.17 39.93 36.98 37.11 37.12 35.92 40.29

            //    // NevSzerint() teszt
            //    List<Probalkozas> prob = new List<Probalkozas>;
            //    prob.Add(new Probalkozas("Torlendo1",9999.99,false));
            //    prob.Add(new Probalkozas("Torlendo2",9999.99,false));
            //    prob.Add(new Probalkozas("Torlendo3",9999.99,false));
            //    KiirProbalkozasList(prob);
            //    Console.WriteLine();

            //    v2.NevSzerint("Anita", prob);
            //    KiirProbalkozasList(prob);
            //    Console.WriteLine();
            //    // Anita 35.91 True
            //    // Anita 38.88 False
            //    // Anita 35.92 True

            Console.WriteLine("Main függvény vége");
        }
    }
}