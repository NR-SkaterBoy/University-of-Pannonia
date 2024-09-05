using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Truck : Vehicle
    {
        int _weight;

        public Truck(string _type, int weight) : base(_type)
        {
            this._weight = weight;
        }

        public  int MaximumTransportableMass
        {
            get { return _weight; }
        }

        public static int NumberOfWheels { get; set; } = 18;

        public void Write()
        {
            Console.WriteLine($"Auto: {Type}, kerekek szama: {NumberOfWheels}, maximalis tomeg: {this.MaximumTransportableMass}");
        }

    }
}
