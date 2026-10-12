using System;

class Program
{
    static void Main()
    {
        Task1And2();
        Task3And4();
    }

    // завдання 1 і 2
    static void Task1And2()
    {
        Console.WriteLine("Завдання 1 і 2");

        Car car = new Car("Toyota Corolla", 180, 1.4, 50, 750000, 4, 1.6, 5);
        car.DisplayInfo();
        car.MoveForward();
        car.OpenTrunk();
        car.Stop();

        Console.WriteLine();

        Truck truck = new Truck("MAN TGS", 110, 9.5, 300, 6, 2500000, 12, true);
        truck.DisplayInfo();
        truck.MoveForward();
        truck.LoadCargo(8);
        truck.LoadCargo(15);
        truck.MoveBackward();
        truck.Stop();

        Console.WriteLine();
    }

    // завдання 3 і 4
    static void Task3And4()
    {
        Console.WriteLine("Завдання 3 і 4");

        Button okButton = new Button(100, 40, "синій", true, "OK");
        okButton.Draw();
        okButton.Click();

        Button cancelButton = new Button(100, 40, "сірий", false, "Скасувати");
        cancelButton.Draw();
        cancelButton.Click();

        Console.WriteLine();

        TextBox loginBox = new TextBox(200, 30, "білий", true, 10);
        loginBox.EnterText("pattaroni");
        loginBox.Draw();
        loginBox.EnterText("дуже довгий логін");
        loginBox.Draw();
    }
}
