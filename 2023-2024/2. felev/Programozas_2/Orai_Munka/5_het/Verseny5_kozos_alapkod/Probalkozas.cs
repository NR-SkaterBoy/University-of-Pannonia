using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verseny5_kozos
{
    internal class Probalkozas
    {
        public string Nev { get; set; }
        public double Tavolsag { get; set; }
        public bool Ervenyes { get; set; }

        public Probalkozas(string nev, double tavolsag, bool ervenyes)
        {
            Nev = nev;
            Tavolsag = tavolsag;
            Ervenyes = ervenyes;
        }
    }
}
