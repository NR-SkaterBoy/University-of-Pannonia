using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVehicle7_onallo
{
    internal class Truck : IVehicle
    {
        public string Brand { get; }
        public int LoadCapacity { get; }

        public Truck(string brand, int loadCapacity)
        {
            this.Brand = brand;
            this.LoadCapacity = loadCapacity;
        }

        public void Move()
        {
            Console.WriteLine($"Moving: {this.Brand} {this.LoadCapacity}") ;
        }

        public override string ToString()
        {
            return $"{this.Brand} {this.LoadCapacity}";
        }
    }
}
