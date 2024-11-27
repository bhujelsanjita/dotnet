using System;


namespace ClassAndObject.Cars

{
    public class Car

    {
        public string Model;
        public string Color;
        public int Year;
        public void Start()
        {
            Console.WriteLine("Car is starting");
        }
        public void Accelerate()
        {
            Console.WriteLine("Car is accelerating");
        }
        public void Brake()
        {
            Console.WriteLine("Car is braking");
        }
    }
}