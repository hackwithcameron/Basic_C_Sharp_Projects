using System;
namespace ExceptionHandling
{
    public class Person
    {
        public Person()
        {
        }
        public int Age { get; set; }

        public static void GetYear(int age)
        {
            DateTime dateTime = DateTime.Today;
            int year = dateTime.Year - age;
            if (age > 0)
            {
                Console.Write("The year you were born was {0}", year);
            }
            else
            {
                throw new AgeException();
            }
        }
    }
}
