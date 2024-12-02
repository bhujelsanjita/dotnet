// properties are like a special doors that let you or get or set the value of private variable in a class.
// they make you control how data is accessed or changed

// why use prioperties
// they keep your data safe by hiding it and letting you control how it is accessed .
using System;
namespace Properties
{
    public class Person
    {
        private string name; // Private variable

        // Property to get and set the name
        public string Name
        {
            get
            {
                return name; // Return the value of the private variable
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // Validate the input
                    name = value; // Assign value to the private variable
                else
                    Console.WriteLine("Name cannot be empty!");
            }
        }

        // Auto-implemented property for Age
        public int Age { get; set; }
    }

    public static class Program
    {
        static void Main()
        {
            Person person = new Person();

            // Setting Name using the property
            person.Name = "John";

            // Getting Name using the property
            Console.WriteLine($"Name: {person.Name}"); // Output: Name: John

            // Setting and Getting Age using auto-implemented property
            person.Age = 25;
            Console.WriteLine($"Age: {person.Age}"); // Output: Age: 25

            // Trying to set an invalid Name
            person.Name = ""; // Output: Name cannot be empty!
        }
    }
}
