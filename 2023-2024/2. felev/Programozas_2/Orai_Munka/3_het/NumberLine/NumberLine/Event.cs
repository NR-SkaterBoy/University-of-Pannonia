using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLine
{
    internal class Event : NumberLine
    {
        private Person _guest;

        public Event() : base(7) { }

        public Person Guest
        {
            get { return _guest; }
            set { _guest = value; }
        }

        public void Write()
        {
            Console.WriteLine($"{this._guest}");
        }
    }
}
