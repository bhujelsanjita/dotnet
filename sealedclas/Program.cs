using System;
namespace SealedClass
{
    // Sealed class
    //A class that cannot be inherited.
    //It is marked with the sealed keyword.
    //Useful when you want to prevent further extension of the class.
    // object can be created.
    public sealed class MySealedClass
    {
        private readonly string message = "Hello, I am a sealed class!";
        public void DisplayMessage()
        {
        
            Console.WriteLine($"Message from sealed class: {message}");
        }
    }
    //public class AnotherClass : MySealedClas
    //{
    //}
    public static class Program
    {
        static void Main()
        {
            MySealedClass sealedInstance = new MySealedClass();
            sealedInstance.DisplayMessage();
           // AnotherClass anotherInstance = new AnotherClass();
        }
    }
}
