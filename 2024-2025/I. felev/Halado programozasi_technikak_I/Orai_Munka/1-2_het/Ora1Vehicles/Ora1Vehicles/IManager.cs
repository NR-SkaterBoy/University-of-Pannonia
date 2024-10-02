using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ora1Vehicles
{
    internal interface IManager
    {
        int VehicleCount { get; }
        void AddVehicle(Vehicle vehicle);
        void Load(string cars, string trucks);
        List<Vehicle> GetTestDrive();
        Vehicle GetMaxTorqueHorsePowerRate();
        Vehicle GetMaxTorqueHorsePowerRateToDeliver();
        void FuelStat();
    }
}
