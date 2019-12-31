using System;

namespace BooleanDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            byte age;
            bool dui;
            byte tickets;
            //bool qualified;



            //***Get users age***

            Console.WriteLine("What is your age?");
            userInput = Console.ReadLine();
            //Convert userInput to byte.
            age = Convert.ToByte(userInput);



            //***Ask if user has any DUIs***

            Console.WriteLine("Have you ever had a DUI? Answer 'true' or 'false'");
            userInput = Console.ReadLine();
            //Convert userInput to boolean.
            dui = Convert.ToBoolean(userInput);



            //***Ask if user has any Speeding Tickets***

            Console.WriteLine("How many speeding tickets do you have?");
            userInput = Console.ReadLine();
            //Convert userInput to Byte.
            tickets = Convert.ToByte(userInput);



            //***Determine if Applicant is qualified***

            Console.WriteLine("Qualified?");
            Console.WriteLine((age > 15) && (dui != true) && (tickets <= 3));
        }
    }
}
