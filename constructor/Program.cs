
//Defination:-A constructor is a special method in a class that is automatically called when an object
//of that class is instatinated
//characteristics:-
//Name: Must have the same name as the class
//Return type: No return type,not even void
//Access Modifiers:-Can have acccess Modifiers
using System;

namespace constructor
{
    public class Person
    {
        public string Name;
        public int Age;
        public static string category;


        //default constructor:- class ko name same xa parameter xaina no return type
        public Person()
        {
            Name = "unknown";
            Age = 0;
        }
        //parametrized constructor:-accpet parameter to initialize field with specific vale
        //use:- 
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        //copy constructor:- A constuctor that creates a new object by copying the values of another object
        //key points:- duplicates an object
        //takes an object of the same class as its parameter
        public Person(Person p)
        {
            Name = p.Name;
            Age = p.Age;
        }
        //static constructor
        // no access modifiers
        // called only oncce during the programs lifetime
        static Person()
        {
            category = "Human";
        }
        //private constructor:- private xa vne private constructor
        // a constructor that prevents the calass from being instantiated from outside 
        // often used in singleton patterns
        // only accesible within the class
        // ensures controlled creation of an object
        private Person(int age, string name)
        {
            Name = name;
            Age = age;
        }
        // factory method to create an object using the private
        public static Person CreateSpecialPerson(int age, string name)
        {
            return new Person(age, name);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Categori: {category} ");
        }

        // destructor is an special method that cleans up resources
        // you dont call it.It return automatically.
        // no access modifiers
        
        ~Person()
        {
            Console.WriteLine("hello bye");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Person p1 = new Person(); //default constructor
            p1.DisplayInfo();

            Person p2 = new Person("john", 30);
            p2.DisplayInfo();

            Person p3 = new Person(p2);
            p3.DisplayInfo();

            Console.WriteLine($"Category from static constructor: {Person.category}");

            Person p4 = Person.CreateSpecialPerson(100, "Special");
            p4.DisplayInfo();


        }
    }
}