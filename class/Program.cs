using System;

namespace Static_Class
{
    public class Program
    {
        static void Main(string[] args)
        {

            int sum = MathUtilities.Add(3, 5);
            int factorial = MathUtilities.Factorial(5);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Factorial: {factorial}");
        }
    }

    public static class MathUtilities
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }


        public static int Factorial(int number)
        {
            if (number <= 1) return 1;
            return number * Factorial(number - 1);
        }
    }
}
//  partial classs-spllitting single class into multiple files
