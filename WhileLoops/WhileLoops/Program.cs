using System;

namespace WhileLoops
{
    class Program
    {
        static void Main()
        {
            string userInput;
            string name;
            bool stop;
            byte num;
            bool guess;


            //Get users name and welcome user. If no input is given the question is looped.
            stop = false;

            while (!stop)
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();

                if (name != "")
                {
                    Console.WriteLine("Welcome, " + name.ToString());
                    stop = true;
                }
            }

            //User guesses a number between 1 and 10.
            Console.WriteLine("Guess a number between 1 and 10");
            userInput = Console.ReadLine();
            num = Convert.ToByte(userInput);
            guess = num == 7;


            do
            {
                switch (num)
                {
                    case 7:
                        Console.WriteLine("Congratulations!!! You guessed the number 7 correctly");
                        guess = true;
                        break;
                    default:
                        Console.WriteLine("\n" + num + " is not the number we are looking for.");
                        Console.WriteLine("Guess a number between 1 and 10");
                        userInput = Console.ReadLine();
                        num = Convert.ToByte(userInput);
                        break;
                }
            } while (!guess);
        }
    }
}
