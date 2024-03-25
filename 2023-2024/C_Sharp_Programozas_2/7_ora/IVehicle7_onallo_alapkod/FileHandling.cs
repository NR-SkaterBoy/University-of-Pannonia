using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace IVehicle7_onallo
{
    internal class FileHandling
    {
        public static void Save(string filename, List<IVehicle> vehicle)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var veh in vehicle)
                {
                    if (veh is Car)
                    {
                        Car car = (Car)veh;
                        sw.WriteLine($"car;{car.Brand};{car.Speed}");
                    } else if (veh is Truck)
                    {
                        Truck truck = (Truck)veh;
                        sw.WriteLine($"truck;{truck.Brand};{truck.LoadCapacity}");
                    }
                }
            }
        }

        public static List<IVehicle> Load(string filename)
        {
            List<IVehicle> vehicles = new List<IVehicle>();
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] parts = line.Split(';');
                    switch (parts[0])
                    {
                        case "car":
                            Car car = new Car(parts[1], int.Parse(parts[2]));
                            vehicles.Add(car);
                            break;
                        default:
                            Truck truck = new Truck(parts[1], int.Parse(parts[2]));
                            vehicles.Add(truck);
                            break;
                    }
                    line = sr.ReadLine();
                }
            }
            return vehicles;
        }
    }
}
