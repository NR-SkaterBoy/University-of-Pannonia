using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Car : Vehicle
    {
        int _transport;

        public Car(string type) : base(type)
        {
        }

        public int NumberOfTransportedPersons
        {
            get { return _transport; }
            set { _transport = value; }
        }

        public void Write()
        {
            Console.WriteLine($"Auto: {Type}, kerekek szama: {NumberOfWheels}, utasok szama: {this.NumberOfTransportedPersons}");
        }
    }
}
