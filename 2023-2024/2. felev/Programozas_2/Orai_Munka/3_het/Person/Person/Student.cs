using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Student : Person
    {
        string _neptunKod;
        int _felevekSzama;

        public Student(string name, int age, string nk, int felev = 1) : base(name, age)
        {
            this._neptunKod = nk;
            this._felevekSzama = felev;
        }

        public string NeptunKod
        {
            get { return _neptunKod; }
        }

        public int FelevekSzama
        {
            get { return _felevekSzama; }
            set { _felevekSzama = value; }
        }

        public void Write()
        {
            base.Write();
            Console.WriteLine($"Neptunkod: {this._neptunKod}, felevek szama: {this._felevekSzama}");
        }

        public bool Strange()
        {
            return _age < 18 + this._felevekSzama / 2;
        }
    }
}
