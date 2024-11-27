using System;
using ClassAndObject.Cars;

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        Car myCar2 = new Car();

        myCar.Model = "Toyota";
        myCar.Color = "Blue";
        myCar.Year = 2022;

        myCar2.Model = "Toyota";
        myCar2.Color = "Blue";
        myCar2.Year = 2022;

        myCar.Start();
        myCar.Accelerate();
        myCar.Brake();
        Console.WriteLine("This is a properties of car my car");
        Console.WriteLine(myCar.Year);
        Console.WriteLine(myCar.Model);
        Console.WriteLine(myCar.Color);
    }
}

