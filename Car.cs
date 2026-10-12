using System;

public class Car : Vehicle
{
    public int DoorsCount { get; set; }
    public double EngineVolume { get; set; }
    public int PassengersCount { get; set; }

    public Car(string model, int speed, double weight, int fuelTank, decimal price,
               int doorsCount, double engineVolume, int passengersCount)
        : base(model, speed, weight, fuelTank, 4, price)
    {
        DoorsCount = doorsCount;
        EngineVolume = engineVolume;
        PassengersCount = passengersCount;
    }

    public void OpenTrunk()
    {
        Console.WriteLine(Model + ": багажник відкрито");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("   Легковий автомобіль: дверей " + DoorsCount + ", двигун " + EngineVolume + " л, пасажирів " + PassengersCount);
    }
}
