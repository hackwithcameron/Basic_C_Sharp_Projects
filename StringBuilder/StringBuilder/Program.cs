using System;
using System.Text;

namespace String
{
    class Program
    {
        static void Main()
        {
            string userInput;
            StringBuilder answer = new StringBuilder();



            //Favorite Color
            Console.WriteLine("What is yuor favorite color?");
            userInput = Console.ReadLine();
            answer.Append("Your favorite color is " + userInput.ToUpper() + ". ");

            //Favorite number
            Console.WriteLine("What is yuor favorite number?");
            userInput = Console.ReadLine();
            answer.Append("Your favorite number is " + userInput + ". ");

            //Favorite Food
            Console.WriteLine("What is yuor favorite food?");
            userInput = Console.ReadLine();
            answer.Append("Your favorite food is " + userInput.ToUpper() + ". ");

            //Print response
            Console.WriteLine(answer);
        }
    }
}
