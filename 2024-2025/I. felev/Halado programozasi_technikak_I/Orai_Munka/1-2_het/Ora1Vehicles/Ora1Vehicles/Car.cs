using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ora1Vehicles
{
    enum Fuel
    {
        Petrol,
        Diesel,
        Gas,
        Electric
    }
    internal class Car : Vehicle
    {
        public Fuel Fuel { get; set; }
        public int Year { get; set; }

        public override bool CanCarry(int size)
        {
            return false;
        }

        public Car()
        {
            
        }
    }
}
