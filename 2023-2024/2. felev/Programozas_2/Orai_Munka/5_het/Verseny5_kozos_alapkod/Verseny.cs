using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Verseny5_kozos
{
    internal class Verseny
    {
        public string megnevezes {  get; }
        private List<Probalkozas> _probalkozas;

        public Verseny(string fileName)
        {
           StreamReader sr = new StreamReader(fileName);
            string sor = sr.ReadLine();
            _probalkozas = new List<Probalkozas>();
            while (sor != null)
            {
                string[] p = sor.Split();
                Probalkozas pr = new Probalkozas(p[0], double.Parse(p[1]), bool.Parse(p[2]));
                _probalkozas.Add(pr);
                sor = sr.ReadLine();
            }
            sr.Close();
        }

        public void Kiir()
        {
            Console.WriteLine(megnevezes);
            foreach (Probalkozas e in _probalkozas)
            {
                Console.WriteLine($"{e.Nev} {e.Tavolsag} {e.Ervenyes}");
            }
        }
    }
}
