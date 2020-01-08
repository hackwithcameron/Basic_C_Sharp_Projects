using System;
using System.Collections.Generic;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areEqual;
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", ID = 1 };
            Employee employee2 = new Employee() { FirstName = "Sample", LastName = "Student", ID = 1 };

            areEqual = employee == employee2;
            Console.WriteLine(areEqual);

 
        }
    }
}
