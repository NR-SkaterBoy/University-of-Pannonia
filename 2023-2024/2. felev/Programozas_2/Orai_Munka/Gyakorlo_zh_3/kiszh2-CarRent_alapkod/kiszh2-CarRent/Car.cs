using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiszh2_CarRent
{
    internal abstract class Car
    {
        public string Id { get; set; } //rendszám
        public string Brand { get;set; } //márka
        public double AverageConsumption { get; set; } //átlagfogyasztás 100km-en
        public int Price { get; set; } //ár
        public int FuelLevel { get; set; } //aktuális üzemanyag mennyiség

        public Car(string id, string brand, double averageConsumption, int price, int fuelLevel)
        {
            Id = id;
            Brand = brand;
            AverageConsumption = averageConsumption;
            Price = price;
            FuelLevel = fuelLevel;
        }

        public void Refuelling(int amountOfFuel)
        {
            FuelLevel += amountOfFuel;
        }

        public abstract double Consumption(int distance);

        public abstract string GetData();
    }
}
