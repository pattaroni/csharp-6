using System;

public class Truck : Vehicle
{
    public double LoadCapacity { get; set; }
    public bool HasTrailer { get; set; }

    public Truck(string model, int speed, double weight, int fuelTank, int wheelsCount, decimal price,
                 double loadCapacity, bool hasTrailer)
        : base(model, speed, weight, fuelTank, wheelsCount, price)
    {
        LoadCapacity = loadCapacity;
        HasTrailer = hasTrailer;
    }

    public void LoadCargo(double tons)
    {
        if (tons > LoadCapacity)
        {
            Console.WriteLine(Model + ": вантаж " + tons + " т перевищує вантажопідйомність " + LoadCapacity + " т");
        }
        else
        {
            Console.WriteLine(Model + ": завантажено " + tons + " т вантажу");
        }
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();

        string trailer = "немає";
        if (HasTrailer)
        {
            trailer = "є";
        }

        Console.WriteLine("   Вантажівка: вантажопідйомність " + LoadCapacity + " т, причіп: " + trailer);
    }
}
