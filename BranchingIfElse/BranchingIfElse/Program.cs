using System;

namespace BranchingIfElse
{
    class Program
    {
        static void Main()
        {
            string userInput;
            ushort weight;
            decimal width;
            decimal height;
            decimal length;
            decimal quote;



            //Welcome User
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");


            //Get package weight
            Console.WriteLine("What is the package weight in lbs?");
            userInput = Console.ReadLine();
            weight = Convert.ToUInt16(userInput);
            //IF package weight is over 50 termianate program ELSE continue with questions...
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                //***Package width***
                Console.WriteLine("What is the package width?");
                userInput = Console.ReadLine();
                //Convert userInput to decimal and save to width
                width = Convert.ToDecimal(userInput);

                //***Package height***
                Console.WriteLine("What is the package height?");
                userInput = Console.ReadLine();
                //Convert userInput to decimal and save to height
                height = Convert.ToDecimal(userInput);

                //***Package length***
                Console.WriteLine("What is the package length?");
                userInput = Console.ReadLine();
                //Convert userInput to decimal and save to length
                length = Convert.ToDecimal(userInput);


                //***Check sum of dimensions***
                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    quote = (width + height + length) * weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C"));
                    Console.WriteLine("Thank You.");
                }
            }

        }
    }
}
