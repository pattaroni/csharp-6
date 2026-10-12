using System;

public class Vehicle
{
    public string Model { get; set; }
    public int Speed { get; set; }
    public double Weight { get; set; }
    public int FuelTank { get; set; }
    public int WheelsCount { get; set; }
    public decimal Price { get; set; }

    public Vehicle(string model, int speed, double weight, int fuelTank, int wheelsCount, decimal price)
    {
        Model = model;
        Speed = speed;
        Weight = weight;
        FuelTank = fuelTank;
        WheelsCount = wheelsCount;
        Price = price;
    }

    public void MoveForward()
    {
        Console.WriteLine(Model + " їде вперед зі швидкістю " + Speed + " км/год");
    }

    public void MoveBackward()
    {
        Console.WriteLine(Model + " їде назад");
    }

    public void Stop()
    {
        Console.WriteLine(Model + " зупинився");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Модель: " + Model + ", вага: " + Weight + " т, бак: " + FuelTank + " л, коліс: " + WheelsCount + ", ціна: " + Price + " грн");
    }
}
