using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ora1Vehicles
{
    internal interface IStore
    {
        void LoadData(string carsjson, string trucksjson);
        List<Vehicle> VehiclesForTestDrive();
        Vehicle HighestTorqueHpRatio();
        Truck HighestTorqueToTransfer(int size);
        void PrintFuelStats();
    }
}
