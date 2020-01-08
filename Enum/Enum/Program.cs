using System;
using Enum;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool stop;
            stop = false;

            while (!stop)
            {
                Console.WriteLine("Please enter a day of the week");
                userInput = Console.ReadLine();

            
                try
                {
                    DayOfWeek day = (DayOfWeek)Enum.Days.DaysOfWeek.Parse(typeof(DayOfWeek), userInput, true);

                    Console.WriteLine(day);
                    stop = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
        }
    }
}
