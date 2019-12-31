using System;

namespace SimpleMathDrill
{
    class Program
    {
        static void Main()
        {
            string userInput;
            int multiplefifty;
            int plusTwentyFive;
            double divide;
            bool greaterThenFifty;
            double remainder;


            //**Returns userInput multiplied by 50**

            Console.WriteLine("Enter a number to be mutiplied by 50:");
            userInput = Console.ReadLine();
            //Convert userInput to Int Value
            multiplefifty = (Convert.ToInt32(userInput)) * 50;
            Console.WriteLine(userInput + " Times 50 = " + multiplefifty.ToString());


            //**Returns userInput plus 25**

            Console.WriteLine("Enter a number that will have 25 added to it:");
            userInput = Console.ReadLine();
            //Convert userInput to Int Value
            plusTwentyFive = (Convert.ToInt32(userInput)) + 25;
            Console.WriteLine(userInput + " Plus 25 = " + plusTwentyFive.ToString());


            //**Returns userInput divided by 12.5**

            Console.WriteLine("Enter a number that will be divided by 12.5:");
            userInput = Console.ReadLine();
            //Convert userInput to double Value
            divide = (Convert.ToDouble(userInput)) / 12.5;
            Console.WriteLine(userInput + " Divided by 12.5 = " + divide.ToString());


            //**Checks to see if userInput in greater then 50**

            Console.WriteLine("Enter a number and I'll Check and see if it's greater then 50:");
            userInput = Console.ReadLine();
            //Convert userInput to double Value
            greaterThenFifty = (Convert.ToInt32(userInput)) > 50;
            Console.WriteLine(greaterThenFifty.ToString());


            //**Returns the remainder of userInput divided by 7**

            Console.WriteLine("Last I'll get the remainder of any number divided by 7:");
            userInput = Console.ReadLine();
            //Convert userInput to double Value
            remainder = (Convert.ToDouble(userInput)) % 7;
            Console.WriteLine("The remainder of " + userInput + " devided by 7 = " + remainder.ToString());

        }
    }
}
