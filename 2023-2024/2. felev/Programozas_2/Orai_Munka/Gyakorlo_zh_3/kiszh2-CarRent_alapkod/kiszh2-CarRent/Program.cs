#region MegoldottFeladatok
//#define PART1  // IVehicle interfesz (1 pont)
//#define PART2ABCD  // PassengerCar osztaly a,b,c,d pontok (1 pont)
//#define PART2EF // PassengerCar osztaly e,f pontok (1 pont)
//#define PART3ABCD  // FreightCar osztaly a,b,c,d pontok (1 pont)
//#define PART3EF // FreightCar osztaly e,f pontok (1 pont)
//#define PART4  // CanGo metodus (2 pont)
//#define PART5  // IAvailable interfesz (1 pont)
//#define PART6  // Available  metodus (2 pont)
#endregion

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace kiszh2_CarRent
{
#if PART1
    class InterfaceIVehicleTest : IVehicle
    {
        public string Category()
        {
            return "Kerekpar";
        }

        public int NumberOfWheels()
        {
            return 2;
        }
    }
#endif

    internal class Program
    {
#if PART2ABCD || PART2EF || PART4 || PART6
        static List<PassengerCar> GetPassengerCars()
        {
            return new List<PassengerCar>
            {
                new PassengerCar("ABC-123", "Ford", 6.2, 45000000, 32, 5),
                new PassengerCar("DCS-448", "Skoda", 8, 600000, 34, 4),
                new PassengerCar("AB-CD-123", "Mercedes", 14.6, 38500000, 17, 6)
            };
        }
#endif

#if PART3ABCD || PART3EF || PART4
        static List<FreightCar> GetFreightCars()
        {
            return new List<FreightCar>
            {
                new FreightCar("BGF-567", "Scania", 66.2, 23000000, 234, 12),
                new FreightCar("KIR-391", "DAF", 54, 42587000, 120, 40),
                new FreightCar("REM-765", "Mercedes", 58.4, 42587000, 43, 40)
            };
        }
#endif

#if PART4
        static void PrintCanGo(Car car, int distance)
        {
            var result = car.CanGo(distance) ? "Igen" : "Nem";
            Console.WriteLine($"A {car.Id} rendszamu {car.Brand} {car.GetType().Name} kepes megtenni {distance} km-t? {result}");
        }
#endif

#if PART6
        static void PrintAvailable(IAvailable car, int distance)
        {
            var result = car.Available(distance) ? "Igen" : "Nem";
            if (car.GetType() == typeof(PassengerCar))
            {
                PassengerCar passengerCar = (PassengerCar)car;
                Console.WriteLine($"A {passengerCar.Id} rendszamu {passengerCar.Brand} elerheto-e {distance} km tavolsagra {passengerCar.FuelLevel} l uzemanyaggal, {passengerCar.AverageConsumption} l atlagfogyasztassal? {result}");
            }
            else
            {
                Console.WriteLine($"Az ismeretlen IAvailable elerheto-e {distance} km tavolsagra? {result}");
            }
        }
#endif

        static void Main(string[] args)
        {
            string CultureName = Thread.CurrentThread.CurrentCulture.Name;
            CultureInfo ci = new CultureInfo(CultureName);
            if (ci.NumberFormat.NumberDecimalSeparator != ".")
            {
                // Forcing use of decimal separator for numerical values
                ci.NumberFormat.NumberDecimalSeparator = ".";
                Thread.CurrentThread.CurrentCulture = ci;
            }

            Console.WriteLine("---Start CarRent---");

#if PART1
            using (TestGuard tg = new TestGuard("PART1"))
            {
                Console.WriteLine();
                if (typeof(IVehicle).IsInterface)
                {
                    IVehicle test = new InterfaceIVehicleTest();
                    Console.WriteLine("!!! IVehicle is an inferface !!!");
                    Console.WriteLine($"Kategoria: {test.Category()}, Kerekek szama: {test.NumberOfWheels()}");
                }
                else
                {
                    Console.WriteLine("!!! IVehicle is not an inferface !!!");
                }
            }//
#endif

#if PART2ABCD
            using (TestGuard tg = new TestGuard("PART2ABCD"))
            {
                Console.WriteLine();
                foreach (var item in GetPassengerCars())
                {
                    Console.WriteLine(item.GetData());
                    Console.WriteLine("Fogyasztasa:");
                    Console.WriteLine($"100 km-en: {item.Consumption(100).ToString("0.00")}");
                    Console.WriteLine($"150 km-en: {item.Consumption(150).ToString("0.00")}");
                    Console.WriteLine($"200 km-en: {item.Consumption(200).ToString("0.00")}");
                    Console.WriteLine($"500 km-en: {item.Consumption(500).ToString("0.00")}");
                    Console.WriteLine("----");
                }
            }//
#endif

#if PART2EF
            using (TestGuard tg = new TestGuard("PART2EF"))
            {
                Console.WriteLine();
                foreach (var item in GetPassengerCars())
                {
                    Console.WriteLine($"A {item.Id} rendszamu, {item.Brand} tipusu, {item.Price} Ft aru szemelyauto besorolasa: {item.Category()}");
                    Console.WriteLine($"A {item.Id} rendszamu, {item.Brand} tipusu szemelyauto kerekeinek szama: {item.NumberOfWheels()}");
                    Console.WriteLine("----");
                }
            }
#endif

#if PART3ABCD
            using (TestGuard tg = new TestGuard("PART3ABCD"))
            {
                Console.WriteLine();
                foreach (var item in GetFreightCars())
                {
                    Console.WriteLine(item.GetData());
                    Console.WriteLine("Fogyasztasa:");
                    Console.WriteLine($"100 km-en: {item.Consumption(100).ToString("0.00")}");
                    Console.WriteLine($"150 km-en: {item.Consumption(150).ToString("0.00")}");
                    Console.WriteLine($"200 km-en: {item.Consumption(200).ToString("0.00")}");
                    Console.WriteLine($"500 km-en: {item.Consumption(500).ToString("0.00")}");
                    Console.WriteLine("----");
                }
            }
#endif

#if PART3EF
            using (TestGuard tg = new TestGuard("PART3EF"))
            {
                Console.WriteLine();
                foreach (var item in GetFreightCars())
                {
                    Console.WriteLine($"A {item.Id} rendszamu, {item.Brand} tipusu, {item.Capacity} t teherbirasu teherauto besorolasa: {item.Category()}");
                    Console.WriteLine($"A {item.Id} rendszamu, {item.Brand} tipusu teherauto kerekeinek szama: {item.NumberOfWheels()}");
                    Console.WriteLine("----");
                }
            }
#endif

#if PART4
            using (TestGuard tg = new TestGuard("PART4"))
            {
                Console.WriteLine();
                List<PassengerCar> passengerCars = GetPassengerCars();
                List<FreightCar> freightCars = GetFreightCars();

                List<Car> cars = new List<Car>();
                foreach (var pCar in passengerCars)
                {
                    cars.Add(pCar);
                }
                foreach (var fCar in freightCars)
                {
                    cars.Add(fCar);
                }
                foreach (var car in cars)
                {
                    Console.WriteLine($"Tankolas elott {car.FuelLevel} l uzemanyaggal, {car.AverageConsumption} l atlagfogyasztassal:");
                    PrintCanGo(car, 100);
                    PrintCanGo(car, 200);
                    PrintCanGo(car, 300);
                    PrintCanGo(car, 500);
                    car.Refuelling(40);
                    Console.WriteLine($"40 l tankolasa utan {car.FuelLevel} l uzemanyaggal, {car.AverageConsumption} l atlagfogyasztassal:");
                    PrintCanGo(car, 100);
                    PrintCanGo(car, 200);
                    PrintCanGo(car, 300);
                    PrintCanGo(car, 500);
                    Console.WriteLine("----");
                }
            }
#endif

#if PART5
            using (TestGuard tg = new TestGuard("PART5"))
            {
                Console.WriteLine();
                if (typeof(IAvailable).IsInterface)
                {
                    Console.WriteLine("!!! IAvailable is an inferface !!!");
                }
                else
                {
                    Console.WriteLine("!!! IAvailable is not an inferface !!!");
                }
            }
#endif

#if PART6
            using (TestGuard tg = new TestGuard("PART6"))
            {
                Console.WriteLine();
                List<PassengerCar> passengerCars = GetPassengerCars();

                List<IAvailable> availableCars = new List<IAvailable>();
                foreach (var pCar in passengerCars)
                {
                    availableCars.Add(pCar);
                }
                foreach (var availableCar in availableCars)
                {
                    PrintAvailable(availableCar, 50);
                    PrintAvailable(availableCar, 150);
                    PrintAvailable(availableCar, 250);
                    Console.WriteLine("----");
                }
            }
#endif

            Console.WriteLine();
            Console.WriteLine("---End CarRent---");
        }
    }

    public class TestGuard : IDisposable
    {
        string _name;

        public TestGuard(string name)
        {
            _name = name;
            Console.WriteLine($"\n\n----START OF {_name}----");
        }

        public void Dispose()
        {
            Console.WriteLine($"----END OF {_name}----");
            GC.SuppressFinalize(this);
        }
    }
}
