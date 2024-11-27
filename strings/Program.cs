using System;

namespace Stringss
{
    public static class Program
    {
        static void Main(string[] args)
        {
            ////Character Conversion
            string s = "Hello";
            string b = "sanjita";
             Console.WriteLine(s.ToUpper());  // Output: "HELLO"
            Console.WriteLine(s.ToLower()); 
            Console.WriteLine(b.ToUpper());  // Output: "HELLO"
            Console.WriteLine(b.ToLower());  // Output: "hello"

            ////String Concatenation
            string str1 = "Hello";
            string str2 = "World";
            string result = str1 + " " + str2;  // Output: "Hello World"
            Console.WriteLine(result.ToUpper());

            string result2 = string.Concat(str1 , str2);  // Output: "Hello World"
            Console.WriteLine(result2);

            ////String Interpolation
            string name = "Alice";
            string mname= "bdr";
            string lname ="lamsal";
            int age = 30;
            string message = $"My name is {name} {mname} {lname} and I am {age} years old.";
            Console.WriteLine(message);  // Output: "My name is Batman and I am 30 years old. i"
        }
    }
}
