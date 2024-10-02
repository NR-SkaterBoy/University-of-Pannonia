using System.Text.Json;

namespace Ora1Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IManager manager = new Manager();
            #region Input files
            try
            {
                manager.Load("cars.json", "trucks.json");
            }
            catch (JsonException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (manager.VehicleCount == 0)
                {
                    var car = new Car()
                    {
                        Name = "Fusion",
                        Brand = "Ford",
                        Year = 2005,
                        Price = 900000,
                        HorsePower = 80,
                        Torque = 86,
                        Fuel = Fuel.Petrol,
                        LicensePlateNumber = "SRV621",
                        Color = "Grey"
                    };
                    manager.AddVehicle(car);
                }
            }
            #endregion

            #region TestDrive
            try
            {
                var testCars = manager.GetTestDrive();
                Console.WriteLine("Test Vehicles: ");
                foreach (var testCar in testCars) {
                    Console.WriteLine(testCar);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            #endregion
        }
    }
}
