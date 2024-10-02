using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ora1Vehicles
{
    internal class VehicleStore : IStore
    {
        List<Vehicle> _vehicles = new List<Vehicle>();
        public Vehicle HighestTorqueHpRatio()
        {
            throw new NotImplementedException();
        }

        public Truck HighestTorqueToTransfer(int size)
        {
            throw new NotImplementedException();
        }

        public void LoadData(string carsjson, string trucksjson)
        {
            Car[]? cars = JsonSerializer.Deserialize<Car[]>(File.ReadAllText(carsjson));
            if (cars != null)
            {
                _vehicles.AddRange(cars);
            }
            Truck[]? trucks = JsonSerializer.Deserialize<Truck[]>(File.ReadAllText(trucksjson));
            _vehicles.AddRange(trucks ?? []);
        }

        public void PrintFuelStats()
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> VehiclesForTestDrive()
        {
            throw new NotImplementedException();
        }
    }
}
