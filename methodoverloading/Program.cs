using System;

namespace Method_Overlaoading
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(float a, float b)
        {
            return Convert.ToInt32(a + b);
        }
        public float Add(float a, float b, float c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }


    public class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Add(int,int):" + calc.Add(6, 6));
            Console.WriteLine("Add(int,int,int):" + calc.Add(6, 6, 5.1));
            Console.WriteLine("Add(double,double):" + calc.Add(6.3, 8.5));
        }
    }
}