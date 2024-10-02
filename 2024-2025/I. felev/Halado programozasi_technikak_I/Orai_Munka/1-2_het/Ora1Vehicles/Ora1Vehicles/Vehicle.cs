using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ora1Vehicles
{


    internal abstract class Vehicle
    {
        public string LicensePlateNumber { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public int Torque { get; set; }
        public int Price { get; set; }


        public double TorqueHpRatio => (double)Torque / HorsePower;

        public abstract bool CanCarry(int size);

        public override string ToString() => $"{LicensePlateNumber}, {Brand}, {Name}";
        public bool CanTestDrive => Price < 10000000;
    }
}
