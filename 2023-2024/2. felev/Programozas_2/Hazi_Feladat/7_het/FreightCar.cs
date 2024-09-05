// FreightCar.cs
using kiszh2_CarRent;
using System;
using System.Diagnostics;

public class FreightCar : Car, IVehicle
{
    public double Capacity { get; }

    public FreightCar(string id, string brand, double averageConsumption, int price, int fuelLevel, double capacity)
        : base(id, brand, averageConsumption, price, fuelLevel)
    {
        Capacity = capacity;
    }

    public override double Consumption(int distance)
    {
        return AverageConsumption / 100 * distance;
    }

    public override string GetData()
    {
        return $"FreightCar - Rendszam: {Id}, Marka: {Brand}, Atlagfogyasztas: {AverageConsumption} l/100km, Ar: {Price} Ft, Uzemanyagmennyiseg: {FuelLevel} l, Teherbiras: {Capacity} t";
    }

    public string Category()
    {
        if (Capacity <= 3.5)
        {
            return "kisteherauto";
        }
        else if (Capacity <= 7.5)
        {
            return "konnyu teherauto";
        }
        else if (Capacity <= 12)
        {
            return "kozepnehez teherauto";
        }
        else
        {
            return "nehez teherauto";
        }
    }

    public override bool CanGo(int distance)
    {
        return FuelLevel >= (AverageConsumption / 100 * distance);
    }

    public int NumberOfWheels()
    {
        if (Capacity <= 3.5)
        {
            return 6;
        }
        else if (Capacity <= 7.5)
        {
            return 8;
        }
        else if (Capacity <= 12)
        {
            return 12;
        }
        else
        {
            return 16;
        }
    }
}
