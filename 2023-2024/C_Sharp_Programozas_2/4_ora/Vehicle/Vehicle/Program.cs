using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("Fiat 500");
            Vehicle v2 = new Vehicle("Hyundai i30");
            Vehicle v3 = new Vehicle("Scania R450");

            Console.WriteLine($"{v1.Type}");
            Console.WriteLine($"{v2.Type}");
            Console.WriteLine($"{v3.Type}");

            //Kerekek száma teszt
            Console.WriteLine();
            Console.WriteLine("Kerekek száma teszt");
            Console.WriteLine($"Vehicle kerekeinek száma: {Vehicle.NumberOfWheels}");
            Vehicle.NumberOfWheels = 5;
            Console.WriteLine($"Vehicle kerekeinek száma: {Vehicle.NumberOfWheels}");

            //Car teszt
            Console.WriteLine();
            Console.WriteLine("Car teszt");
            Car c1 = new Car("Trabant 601");
            Car c2 = new Car("Citroen C4");
            c1.NumberOfTransportedPersons = 4;
            c2.NumberOfTransportedPersons = 5;
            Console.WriteLine($"{c1.Type} szállítható személyek száma: {c1.NumberOfTransportedPersons}");
            Console.WriteLine($"{c2.Type} szállítható személyek száma: {c2.NumberOfTransportedPersons}");

            //Car Write teszt
            Console.WriteLine();
            Console.WriteLine("Car Write teszt");
            c1.Write();
            Vehicle.NumberOfWheels = 4;
            c2.Write();

            //Truck teszt
            Console.WriteLine();
            Console.WriteLine("Truck teszt");
            Truck t1 = new Truck("Iveco Strails S-WAY", 18);
            Truck t2 = new Truck("MAN TGX", 24);
            Console.WriteLine($"{t1.Type} maximálisan szállítható tömeg: {t1.MaximumTransportableMass} tonna");
            Console.WriteLine($"{t2.Type} maximálisan szállítható tömeg: {t2.MaximumTransportableMass} tonna");

            //Truck kerekek száma
            Console.WriteLine();
            Console.WriteLine("Truck kerekek száma");
            Console.WriteLine($"Truck kerekeinek száma: {Truck.NumberOfWheels}");
            Truck.NumberOfWheels = 16;
            Console.WriteLine($"Truck kerekeinek száma: {Truck.NumberOfWheels}");

            ////Truck Write teszt
            Console.WriteLine();
            Console.WriteLine("Truck Write teszt");
            t1.Write();
            Truck.NumberOfWheels = 20;
            t2.Write();

            Console.ReadKey();
        }
    }
}