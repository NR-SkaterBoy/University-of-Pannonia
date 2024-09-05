using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiszh1Pelda
{
    internal class MerkozesSorozat : Merkozes
    {
        int[] _eredmenyek;
        static int _rosszIdx = 0;

        public static int RosszIndexek { get { return _rosszIdx; } }

        public MerkozesSorozat(string hazaiCsapat, string vendegCsapat, int idx = 0) : base(hazaiCsapat, vendegCsapat)
        {
            _eredmenyek = new int[idx];
            for (int i = 0; i < idx; i++)
            {
                this._eredmenyek[i] = 0;
            }
        }

        public void UjEredmeny(int idx, int eredmeny)
        {
            this._eredmenyek[idx] = eredmeny;
        }

        public string NyertesCsapat()
        {
            int dontetlen = this._eredmenyek.Count(x => x == 0);
            int gyozelem = this._eredmenyek.Count(x => x == 1);
            int vereseg = this._eredmenyek.Count(x => x == 2);

            if (gyozelem > vereseg)
            {
                return base.HazaiCsapat;
            }
            else if (gyozelem < vereseg)
            {
                return base.VendegCsapat;
            }
            else
            {
                return "Dontetlen";
            }
        }

        public void Kiir(bool opt = false)
        {

            Console.WriteLine($"{base.HazaiCsapat} vs {base.VendegCsapat}");
            if (!opt)
            {
                for (int i = 0; i < this._eredmenyek.Length; i++)
                {
                    Console.WriteLine($"{i+1}: {this._eredmenyek[i]}");
                }   
            } else
            {
                for (int i = 0; i < this._eredmenyek.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {NyertesCsapat()}");
                }
            }
            
        }

    }
}
