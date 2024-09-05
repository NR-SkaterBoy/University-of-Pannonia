using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kiszh1Pelda
{
    internal class MerkozesSorozat : Merkozes
    {
        private int[] _meccsek;
        static int _rosszindex = 0;

        public MerkozesSorozat(string hazaiCsapat, string vendegCsapat, int index) : base(hazaiCsapat, vendegCsapat)
        {
            _meccsek = new int[index];

            for (int i = 0; i < index; i++)
                _meccsek[i] = 0;
        }

        public static int RosszIndexek
        {
            get { return _rosszindex; }
        }

        public void UjEredmeny(int index, int eredmeny)
        {
            if (index < _meccsek.Length && index >= 0)
                _meccsek[index] = eredmeny;
            else
                _rosszindex++;
        }

        public string NyertesCsapat()
        {
            int cntHazai = 0;
            int cntVendeg = 0;
            int dontetlen = 0;

            for (int i = 0; i < _meccsek.Length; i++)
            {
                if (_meccsek[i] == 0)
                    dontetlen++;
                if (_meccsek[i] == 1)
                    cntHazai++;
                if (_meccsek[i] == 2)
                    cntVendeg++;
            }

            if (cntHazai > cntVendeg)
                return base.HazaiCsapat;
            else if (cntVendeg > cntHazai)
                return base.VendegCsapat;
            else return "Dontetlen";
        }

        public void Kiir(bool optional = false)
        {
            Console.WriteLine($"{base.HazaiCsapat} vs {base.VendegCsapat}: ");

            if (optional == true)
            {
                for (int i = 0; i < _meccsek.Length; i++)
                {
                    if (_meccsek[i] == 1)
                        Console.WriteLine($"{i + 1}: {base.HazaiCsapat}");
                    else if (_meccsek[i] == 2)
                        Console.WriteLine($"{i + 1}: {base.VendegCsapat}");
                    else
                        Console.WriteLine($"{i + 1}: Dontetlen");

                }
            }
            else
            {
                for (int i = 0; i < _meccsek.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {_meccsek[i]}");
                }
            }

        }
    }
}