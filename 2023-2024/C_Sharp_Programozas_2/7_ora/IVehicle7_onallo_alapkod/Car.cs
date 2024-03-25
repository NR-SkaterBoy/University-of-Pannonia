using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVehicle7_onallo
{
    internal class Car : IVehicle
    {
        public string Brand { get; }
        public int Speed { get; }

        public Car(string brand, int speed)
        { 
            this.Brand = brand;
            this.Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"Moving: {this.Brand} {this.Speed}");
        }
    }
}
