using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge;
            
            try
            {
                Console.WriteLine("What is your age?");
                userAge = Convert.ToInt32(Console.ReadLine());
                Person.GetYear(userAge);
            }
            catch (AgeException)
            {
                Console.WriteLine("You have to be older then that!");
            }
            catch (Exception)
            {
                Console.WriteLine("An Error has occured. Please contact Admin");
            }
        }
    }
}
