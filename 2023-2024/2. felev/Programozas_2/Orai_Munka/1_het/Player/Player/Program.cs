using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Player
    {
        public string _name;
        public int _jerseyNumber;
        public int _age;
        public double _weight;
        public int _goals;
        public int _matchNumber;
        public bool _isNational;
    }

    internal class Program
    {

        static Player[] BekerPlayerAdat(int db)
        {
            Player[] player = new Player[db];
            for (int i = 0; i < player.Length; i++)
            {
                Console.WriteLine($"Kerlek add meg az {i+1} jatekos adatait");
                Console.Write("Jatekos neve: ");
                player[i]._name = Console.ReadLine();
                Console.Write("Mezszama: ");
                player[i]._jerseyNumber = int.Parse(Console.ReadLine());
                Console.Write("Kora: ");
                player[i]._age = int.Parse(Console.ReadLine());
                Console.Write("Sulya: ");
                player[i]._weight = double.Parse(Console.ReadLine());
                Console.Write("Golok szama: ");
                player[i]._goals = int.Parse(Console.ReadLine());
                Console.Write("Meccsek szama: ");
                player[i]._matchNumber = int.Parse(Console.ReadLine());
                Console.Write("Nemzetkozi meccsen resztvett? (true or false): ");
                player[i]._isNational = bool.Parse(Console.ReadLine());
            }
            return player;
        }

        static void KiirPlayerAdat(Player[] player)
        {
            Console.WriteLine("Jatekosok adatai: ");
            // Nem számít az index
            foreach (var jatekos in player)
            {
                Console.WriteLine($"Neve: {jatekos._name}, mezsszama: {jatekos._jerseyNumber}, kora: {jatekos._age}, sulya: {jatekos._weight}, golok: {jatekos._goals}, jatszott mecssek: {jatekos._matchNumber} nemzetkozi: {jatekos._isNational}");
            }
        }

        static int Legidosebb(Player[] players)
        {
            int legidosebb_idx = -1;
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i]._age > players[legidosebb_idx]._age)
                {
                    legidosebb_idx = i;
                }
            }
            return legidosebb_idx;
        }

        static int EnnyitJatszott(Player[] players, int jatszott = 10) {
            int db = 0;
            foreach(var match in players)
            {
                if (match._matchNumber >= jatszott)
                {
                    db++;
                }
            }
            return db;
        }

        static void Mezszam(Player[] player, int mez)
        {
            bool vanMez = false;
            int idx = -1;
            for (int i = 0; i < player.Length; i++)
            {
                if (player[i]._jerseyNumber == mez)
                {
                    vanMez = true;
                    idx = i;
                    break;
                }
            }
                

            if (vanMez)
            {
                Console.WriteLine($"Neve: {player[idx]._name}, mezsszama: {player[idx]._jerseyNumber}, kora: {player[idx]._age}, sulya: {player[idx]._weight}, golok: {player[idx]._goals}, jatszott mecssek: {player[idx]._matchNumber}nemzetkozi: {player[idx]._isNational}");
            } else Console.WriteLine("Nincs ilyen jatekos");
        }

        static void Main(string[] args)
        {
            Console.Write("Hany jatekos adatait taroljam: ");
            int darab = int.Parse(Console.ReadLine());
            Player[] player = BekerPlayerAdat(darab);
            KiirPlayerAdat(player);
            int idx = Legidosebb(player);
            Console.WriteLine($"Neve: {player[idx]._name}, mezsszama: {player[idx]._jerseyNumber}, kora: {player[idx]._age}, sulya: {player[idx]._weight}, golok: {player[idx]._goals}, jatszott mecssek: {player[idx]._matchNumber}nemzetkozi: {player[idx]._isNational}");
            Console.Write("Jatszott meccsek szama (0, ha az alap 10 mecsset jatekosok szama kell): ");
            int jatszott = int.Parse(Console.ReadLine());
            int ennyitJatszott = jatszott > 0 ? EnnyitJatszott(player, jatszott) : EnnyitJatszott(player);
            Console.WriteLine($"{ennyitJatszott} jatekos van");
            Console.Write("Legalabb ennyit jatszott: ");
            int ujennyit = int.Parse(Console.ReadLine());
            Console.WriteLine($"{EnnyitJatszott(player, ujennyit)} jatekos van");
            Console.Write("Mez szama: ");
            int mez = int.Parse(Console.ReadLine());
            Mezszam(player, mez);
        }
    }
}
