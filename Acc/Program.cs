using System;

namespace Test.AccessModifier
{
    public class AccessModifiersDemo
    {
        public int PublicMember { get; set; }

        private string PrivateMember { get; set; }

        protected double ProtectedMember { get; set; } 
        internal bool InternalMember { get; set; } 

        protected internal DateTime ProtectedInternalMember { get; set; } 
        private protected string PrivateProtectedMember { get; set; } 

        public AccessModifiersDemo()
        {
            PublicMember = 42;
            PrivateMember = "private data";
            ProtectedMember = 3.14;
            InternalMember = true;
            ProtectedInternalMember = DateTime.Now; // Corrected type name
            PrivateProtectedMember = "Restricted access";
        }

        public void DisplayPublicData()
        {
            Console.WriteLine($"Public member: {PublicMember}");
        }

        private void DisplayPrivateData()
        {
            Console.WriteLine($"Private member: {PrivateMember}");
        }

        protected void DisplayProtectedData()
        {
            Console.WriteLine($"Protected member: {ProtectedMember}");
        }

        internal void DisplayInternalData()
        {
            Console.WriteLine($"Internal member: {InternalMember}");
        }

        protected internal void DisplayProtectedInternalData()
        {
            Console.WriteLine($"Protected internal member: {ProtectedInternalMember}");
        }
    }

    class Program
    {
        static void Main()
        {
            AccessModifiersDemo demo = new AccessModifiersDemo();

            demo.DisplayPublicData();
            demo.DisplayInternalData();
            // demo.DisplayPrivateData();
            demo.DisplayProtectedInternalData();

            // Note: Cannot access private, protected, or private protected members directly here.
        }
    }
}
