using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ora1Vehicles
{
    internal class Manager : IManager
    {

        public Manager()
        {
            Vehicles = new List<Vehicle>();
        }

        public List<Vehicle> Vehicles { get; set; }

        public int VehicleCount => Vehicles.Count;

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public void FuelStat()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetMaxTorqueHorsePowerRate()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetMaxTorqueHorsePowerRateToDeliver()
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetTestDrive()
        {
            List<Vehicle> testDrives = new List<Vehicle>();
            foreach (Vehicle vehicle in Vehicles) {
                if (vehicle.CanTestDrive) {
                    testDrives.Add(vehicle);
                }
            }

            if (testDrives.Any())
            {
                throw new CustomException();
            }
            return testDrives;
        }

        public void Load(string cars, string trucks)
        {
            var carFile = File.ReadAllText(cars);
            var truckFile = File.ReadAllText(trucks);

            Vehicles.AddRange(JsonSerializer.Deserialize<List<Car>>(carFile));
            Vehicles.AddRange(JsonSerializer.Deserialize<List<Car>>(truckFile));

            if (Vehicles.Count == 0)
            {
                throw new Exception("Empty Vehicle List!");
            }

            Console.WriteLine("Vehicles has been loaded!");
        }
    }
}
