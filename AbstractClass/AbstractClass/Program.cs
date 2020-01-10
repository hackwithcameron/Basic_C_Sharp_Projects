using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<Employee> joes = new List<Employee>();

            employees.Add(new Employee()
            {
                FirstName = "Joe", LastName = "Robert", ID = 1
            });
            employees.Add(new Employee()
            {
                FirstName = "Carls", LastName = "Jr", ID = 2
            });
            employees.Add(new Employee()
            {
                FirstName = "John", LastName = "Smith", ID = 3
            });
            employees.Add(new Employee()
            {
                FirstName = "Joey", LastName = "Tribbiani", ID = 4
            });
            employees.Add(new Employee()
            {
                FirstName = "Rachel", LastName = "Green", ID = 5
            });
            employees.Add(new Employee()
            {
                FirstName = "Joe", LastName = "Lewis", ID = 6
            });
            employees.Add(new Employee()
            {
                FirstName = "Ross", LastName = "Geller", ID = 7
            });
            employees.Add(new Employee()
            {
                FirstName = "Pheobe", LastName = "Buffay", ID = 8
            });
            employees.Add(new Employee()
            {
                FirstName = "Chandler", LastName = "Bing", ID = 9
            });
            employees.Add(new Employee()
            {
                FirstName = "Monica", LastName = "Geller", ID = 10
            });

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            foreach (Employee joe in joes)
            {
                Console.WriteLine("{0} {1}",joe.FirstName.ToString(), joe.LastName.ToString());
            }

            //Using Lambda Function
            List<Employee> joes2 = employees.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> ids = employees.Where(x => x.ID > 5).ToList();

            Console.WriteLine("\nUsing Lambda Function:");
            foreach (Employee joe in joes2)
            {
                Console.WriteLine("{0} {1}", joe.FirstName.ToString(), joe.LastName.ToString());
            }
            Console.WriteLine("\n");
            foreach (Employee employee in ids)
            {
                Console.WriteLine("{0} {1} ID: {2}", employee.FirstName.ToString(), employee.LastName.ToString(), employee.ID.ToString());
            }
        }
    }
}
