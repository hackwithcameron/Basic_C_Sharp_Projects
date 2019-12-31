using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main()
        {
            string userInput;
            ushort p1Hourly;
            ushort p1Weekly;
            int p1Total;
            ushort p2Hourly;
            ushort p2Weekly;
            int p2Total;
            bool comparison;


            //Person 1

            Console.WriteLine("Anonymous Income Comparison Program");
			Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            userInput = Console.ReadLine();
            p1Hourly = (Convert.ToUInt16(userInput));
            Console.WriteLine("Hours worked per week?");
            userInput = Console.ReadLine();
            p1Weekly = (Convert.ToUInt16(userInput));
            p1Total = p1Hourly * p1Weekly;


            //Person 2

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            userInput = Console.ReadLine();
            p2Hourly = (Convert.ToUInt16(userInput));
            Console.WriteLine("Hours worked per week?");
            userInput = Console.ReadLine();
            p2Weekly = (Convert.ToUInt16(userInput));
            p2Total = p2Hourly * p2Weekly;


            //Comparison

            Console.WriteLine("Weekly salary of Person 1 is:");
            Console.WriteLine(p1Total.ToString());
            Console.WriteLine("Weekly salary of Person 2 is:");
            Console.WriteLine(p2Total.ToString());
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            comparison = p1Total > p2Total;
            Console.WriteLine(comparison);

        }
    }
}
