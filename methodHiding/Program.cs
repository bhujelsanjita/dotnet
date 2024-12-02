using System;
 namespace MethodHiding{

    public class BaseClass
    {
         public void Display(){
            Console.WriteLine("base class method");
         }
    }
    public class DerivedClass:BaseClass
    {
         public new void Display(){
            Console.WriteLine("Derived class method");
         }
    }
    public static class Program{
        static void Main(){
            BaseClass baseob = new BaseClass();
            baseob.Display();

            DerivedClass derivedobj = new DerivedClass();
            derivedobj.Display();

            BaseClass baseRef = new BaseClass();
            baseRef.Display();
        }
    }
 }