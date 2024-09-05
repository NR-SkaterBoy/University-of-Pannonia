/**
 * A program egy vásárlás adatait kezeli, amelyben három módon adhatunk meg terméket.
 * Minden vásárolt termék a bemeneti fájlban egy sort foglal el, az adataik szóközzel elválasztva szerepelnek. A termék fajtái:

 * Egyedüli termék: egy darab termék, aminek van egy kódja és egy egységára. A kódja 'S' karakterrel kezdődik.
 * Több termék egy tételben: több ugyanolyan termék egy elemként a listában. Van hozzá termékkód, darabonkénti egységár, 
 * valamint darabszám. A kódja 'M' karakterrel kezdődik.
 * Termék csomag: Ezek a termékek egység méretű csomagokban vannak. Az adatok között van termékkód,
 * darabonkénti egységár, valamint a vásárolt csomagok száma. A kódja 'P' karakterrel kezdődik.
 * A csomag mérete egységes minden ilyen termékre, de állítható a programban (lásd később).
 * Egészítsd ki az alábbi programot, úgy, hogy a main-ben lévő kód működjön! A megfelelő osztályokat is létre kell hozni!

 * A ReadProducts metódus a paraméterben kapott fájlnévből olvassa be a termékeket egy listába!
 * A GetTotalCost metódus adja vissza a terméklista árát!
 * A SetPackageSize metódus állítsa be, hogy egy termék csomagban egységesen mennyi termék található!
 * Például az első bemeneti adatok esetén a fájl (products.txt) tartalma:

 * SDA3F1F322 230              -- egy darab termék, melynek az ára 230
 * SE7F6WF2FD 560              -- egy darab termék, melynek az ára 560
 * MTR3GFD251 150 8            -- 8 darab egyforma termék, darabjának ára 150
 * MRE24TQ241 230 4            -- 4 darab egyforma termék, darabjának ára 230
 * P42TFS22FG 60 1             -- 1 csomagnyi csomagolt termék, melyben minden termék ára 60 (de itt nincs megadva a csomag mérete)
 * PEWRD352R2 45 3             -- 3 csomagnyi csomagolt termék, melyben minden termék ára 45 (de itt nincs megadva a csomag mérete)
 * Az összár meghatározásához ismerni kell a csomagokban lévő darabszámot. Ezt a példában először 5-re állítjuk, majd 100-ra.

 * Az első 4 elem ára nem függ a csomag mérettől, ezek mindig 230, 560, 8*150=1200, 4*230=920.

 * Amikor a csomagméret 5, akkor az 5. sorban 1 csomag * 5 termék = 5 termék van, melyek ára darabonként 60,
 * így az összár 300, míg a 6. sorban 3 csomag * 5 termék = 15 termék van, melyek ára darabonként 45, így az összár 675.
 * Ha a csomagméret 100, akkor az 5. sorban 1*100= 100 termék, melyek összára 6000, míg a 6. sorban 3*100=300 termék van,
 * melyek összára 13500.

 * A teljes lista összes ára így 5-ös csomagméret esetén 3885, míg 100-as csomagméret estén 22410.
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace VirtualHaziTest
{
    // A Product egy absztrakt osztály
    abstract class Product
    {

        public abstract string code();
        public abstract int cost();

        public abstract int mennyisegg();

        public int costofone
        {
            get { return cost(); }
        }

    }
    // Ide jöhetnek egyéb osztályok

    class egydarab : Product
    {
        int _cost;
        string _name;
        public egydarab(int cost, string name)
        {
            _cost = cost;
            _name = name;
        }

        public override int cost()
        {
            return _cost;
        }
        public override string code()
        {
            return _name;
        }
        public override int mennyisegg()
        {
            return 1;
        }

    }



    class tobbdarab : Product
    {
        int _cost;
        string _name;
        int mennyiseg_;

        public int mennyiseg
        {
            set
            {
                mennyiseg_ = value;
            }
        }
        public tobbdarab(int cost, string name, int mennyiseg)
        {
            _cost = cost;
            _name = name;
            mennyiseg_ = mennyiseg;
        }
        public override int cost()
        {
            return _cost;
        }
        public override string code()
        {
            return _name;
        }
        public override int mennyisegg()
        {
            return mennyiseg_;
        }

    }

    class csomag : Product
    {
        int _cost;
        string _name;
        public override int cost()
        {
            return _cost;
        }
        public override string code()
        {
            return _name;
        }
        public override int mennyisegg()
        {
            return mennyiseg2_;
        }
        int mennyiseg2_;
        public csomag(int cost, string name, int mennyiseg)
        {
            _cost = cost;
            _name = name;
            mennyiseg2_ = mennyiseg;
        }
        public int mennyiseg2
        {
            get
            {
                return mennyiseg2_;
            }
            set
            {
                mennyiseg2_ = value;
            }
        }
    }

    class Program
    {
        // Ide jöhetnek a Main által meghívott metódusok

        public static List<Product> ReadProducts(string name)
        {
            List<Product> products = new List<Product>();
            StreamReader reader = new StreamReader(name);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] stomb = line.Split(' ');
                if (stomb[0][0] == 'S')
                {
                    products.Add(new egydarab(int.Parse(stomb[1]), stomb[0]));
                }
                else if (stomb[0][0] == 'M')
                {
                    products.Add(new tobbdarab(int.Parse(stomb[1]), stomb[0], int.Parse(stomb[2])));
                }
                else
                {
                    products.Add(new csomag(int.Parse(stomb[1]), stomb[0], int.Parse(stomb[2])));
                }
            }


            return products;
        }
        static int csmeretxd;
        public static void SetPackageSize(int meret)
        {
            csmeretxd = meret;
        }

        public static int GetTotalCost(List<Product> ls)
        {
            int osszeg = 0;
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i] is egydarab)
                {
                    osszeg += ls[i].costofone;
                }
                else if (ls[i] is tobbdarab)
                {
                    osszeg += ls[i].costofone * ls[i].mennyisegg();
                }
                else
                {
                    osszeg += ls[i].costofone * ls[i].mennyisegg() * csmeretxd;
                }
            }
            return osszeg;
        }



        static void Main(string[] args)
        {
            string filename = Console.ReadLine();
            int size1 = int.Parse(Console.ReadLine());
            int size2 = int.Parse(Console.ReadLine());
            List<Product> products = ReadProducts(filename);
            SetPackageSize(size1);
            Console.WriteLine(GetTotalCost(products));
            SetPackageSize(size2);
            Console.WriteLine(GetTotalCost(products));
        }
    }
}