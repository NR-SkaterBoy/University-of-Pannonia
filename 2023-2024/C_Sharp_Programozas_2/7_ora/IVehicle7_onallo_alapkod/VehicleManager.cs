using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVehicle7_onallo
{
    internal class VehicleManager
    {
        private List<IVehicle> vehicles = new List<IVehicle>();

        public List<IVehicle> Vehicles { get { return vehicles; } }

        public void Print()
        {
            Console.WriteLine("Vehicle list:");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

        public void AddVehicle(IVehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void MoveVehicles()
        {
            foreach (var e in vehicles)
            {
                if (e is Car)
                {
                    e.Move();
                } else if (e is Truck) {
                    e.Move();
                }
            }
        }
    }
}
