// The base calss method must be marked with virtual of abstract.
// the derived method must use the ovveride keyword.
// enables run time polymorphism 
// uses
// used when a subclass needs to modify or extend
//  the behaviour of a methos defines in a base class
// mostly used in Payment System

using System;

namespace Method_OverRide
{
    public class Animal
    {
        // use virtual or abstract in base class
        // using virtual for  implemenatation
        public virtual void Speak()
        {

            Console.WriteLine("Animal speaks");
        }
    }
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dogs barks");
        }
    }
    public class Program
    {
        public static void Main(){

            Animal MyAnimal = new Animal();
            MyAnimal.Speak();

            Animal myDog = new  Dog();
            myDog.Speak();

            Dog myDog2 = new Dog();
            myDog2.Speak();
         }
    }

}