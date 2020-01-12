using System;

namespace UsingDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine("Please enter a number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            // Adds userNum to date
            DateTime answer = date.AddHours(userNum);
            Console.WriteLine("In {0} hours it will be {1}", userNum, answer);
        }
    }
}
