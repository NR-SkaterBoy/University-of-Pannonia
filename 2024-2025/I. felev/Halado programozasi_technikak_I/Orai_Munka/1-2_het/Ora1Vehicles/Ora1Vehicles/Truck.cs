using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ora1Vehicles
{
    internal class Truck : Vehicle
    {
        public int PayloadCapacity { get; set; }
        public int NumberOfAxles { get; set; }

        public override bool CanCarry(int size)
        {
            return size <= PayloadCapacity;
        }

        public Truck()
        {
            
        }
    }
}
