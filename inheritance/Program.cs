// See https://aka.ms/new-console-template for more information
using System;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        // Test the TestClass
        // TestClass testClass = new TestClass();
        // testClass.derived2();

        // Test the MultipleInheritance class
        MultipleInheritance multipleInheritance = new MultipleInheritance();
        multipleInheritance.FirstMethod();
        multipleInheritance.SecondMethod();
    }
}

public class BaseClass
{
    public void BaseMethod()
    {
        Console.WriteLine("Base method");
    }
}

public class DerivedClass : BaseClass
{
    public void DerivedMethod()
    {
        Console.WriteLine("Derived method");
    }
}

class TestClass : DerivedClass
{
    public void derived2()
    {
        DerivedClass derivedClass = new DerivedClass();
        derivedClass.BaseMethod();
        derivedClass.DerivedMethod();
    }
}

public interface IFirst
{
    void FirstMethod();
}

public interface ISecond
{
    void SecondMethod();
}

public class MultipleInheritance : IFirst, ISecond
{
    public void FirstMethod()
    {
        Console.WriteLine("First method");
    }

    public void SecondMethod()
    {
        Console.WriteLine("Second method");
    }
}
