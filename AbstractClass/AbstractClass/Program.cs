using System;
using System.Collections.Generic;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeStuff = new Employee<string>();
            employeeStuff.Things = new List<string>();
            employeeStuff.Things.Add("Speakers");
            employeeStuff.Things.Add("Cell Phone");
            employeeStuff.Things.Add("T.V.");
            employeeStuff.Things.Add("Coffee Cup");
            employeeStuff.Things.Add("Computer");



            Employee<int> employeeNums = new Employee<int>();
            employeeNums.Things = new List<int>();
            employeeNums.Things.Add(5);
            employeeNums.Things.Add(17);
            employeeNums.Things.Add(28);
            employeeNums.Things.Add(34);
            employeeNums.Things.Add(56);


            foreach (string thing in employeeStuff.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int num in employeeNums.Things)
            {
                Console.WriteLine(num);
            }


            //********* Compairs Employees using IDs *********

            //bool areEqual;
            //Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", ID = 1 };
            //Employee employee2 = new Employee() { FirstName = "Sample", LastName = "Student", ID = 2 };

            //areEqual = employee == employee2;
            //Console.WriteLine(areEqual);


        }
    }
}
