using System;
using System.Collections.Generic;
using System.IO;

namespace IVehicle7_onallo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleManager vehicleManager = new VehicleManager();

            // Testing adding cars and trucks to the VehicleManager list
            vehicleManager.AddVehicle(new Car("Toyota", 120));
            vehicleManager.AddVehicle(new Truck("Volvo", 5000));

            vehicleManager.Print();
            Console.WriteLine();

            // Testing movement
            vehicleManager.MoveVehicles();
            Console.WriteLine();

            // Testing file handling - save and load
            FileHandling.Save("vehicles.txt", vehicleManager.Vehicles);
            List<IVehicle> loadedVehicles = FileHandling.Load("vehicles.txt");
            foreach (var vehicle in loadedVehicles)
            {
                vehicleManager.AddVehicle(vehicle);
            }
            Console.WriteLine();
            vehicleManager.Print();
            Console.WriteLine();

            //// Testing countdown
            //vehicleManager.Countdown();
        }
    }
}