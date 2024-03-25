using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject
{
    internal class Subject
    {
        private string _name;
        private uint[] _marks;

        public Subject(string name, uint[] marks)
        {
            this._name = name;
            this._marks = marks;
        }

        public string Name { get { return _name; } }
        public uint[] Marks { get { return _marks; } }

        public string KiirAdat()
        {
            return $"Tantargy neve: {this.Name}, jegyek: {string.Join(" ", this.Marks)}";
        }

        public double Atltag()
        {
            return this._marks.Average(x => x);
        }

        public void AddUjJegy(uint ujjegy)
        {
            Array.Resize(ref this._marks, this._marks.Length + 1);
            this._marks[this._marks.Length - 1] = ujjegy;
        }

        public int szamolJegy(uint jegy)
        {
            return Marks.Count(x => x == jegy);
        }
    }
}
