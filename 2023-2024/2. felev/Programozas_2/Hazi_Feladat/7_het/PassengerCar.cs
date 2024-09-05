using kiszh2_CarRent;
using System;
using System.Diagnostics;

public class PassengerCar : Car, IVehicle, IAvailable
{
    public int NumberOfTransportedPersons { get; }

    public PassengerCar(string id, string brand, double averageConsumption, int price, int fuelLevel, int numberOfTransportedPersons)
        : base(id, brand, averageConsumption, price, fuelLevel)
    {
        NumberOfTransportedPersons = numberOfTransportedPersons;
    }

    public override double Consumption(int distance)
    {
        return AverageConsumption / 100 * distance;
    }

    public override string GetData()
    {
        return $"PassengerCar - Rendszam: {Id}, Marka: {Brand}, Atlagfogyasztas: {AverageConsumption} l/100km, Ar: {Price} Ft, Uzemanyagmennyiseg: {FuelLevel} l, Szallithato szemelyek szama: {NumberOfTransportedPersons} fo";
    }

    public string Category()
    {
        if (Price < 2000000)
        {
            return "also kategoria";
        }
        else if (Price < 15000000)
        {
            return "kozep kategoria";
        }
        else
        {
            return "felso kategoria ";
        }
    }

    public override bool CanGo(int distance)
    {
        return FuelLevel >= (AverageConsumption / 100 * distance);
    }


    public int NumberOfWheels()
    {
        return 4;
    }

    public bool Available(int distance)
    {
        return FuelLevel >= (AverageConsumption / 100 * distance);
    }
}
