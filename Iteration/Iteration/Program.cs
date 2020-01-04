using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool stop;
            string[] grettingArray = { "Hello", "Hola", "Bonjour", "Ciao" };
            List<string> names = new List<string>() { "Chandler", "Monica", "Joey", "Ross", "Rachel", "Phoebe" };
            List<string> names2 = new List<string>() { "Chandler", "Monica", "Joey", "Ross", "Rachel", "Phoebe", "Chandler", "Monica", "Joey", "Ross", "Rachel", "Phoebe" };
            List<int> index = new List<int>();




            //Greets user in four languages
            Console.WriteLine("What is your name?");
            userInput = Console.ReadLine();

            for (int i = 0; i < grettingArray.Length; i++)
            {
                Console.WriteLine(grettingArray[i] + " " + char.ToUpper(userInput[0]) + userInput.Substring(1));

            }

            //Counts to ten
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //Finds index of name for user
            stop = false;

            while (!stop)
            {
                Console.WriteLine("Choose a name to find its position in the list");
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
                userInput = Console.ReadLine();
                userInput.ToLower();

                foreach (string name in names)
                {
                    if (name.ToLower() == userInput)
                    {
                        Console.WriteLine("The index of " + userInput + " is " + names.IndexOf(name));
                        stop = true;
                    }
                }
                if (!stop)
                {
                    Console.WriteLine("That name is not on the list, please try again \n");
                }

            }


            
            stop = false;

            while (!stop)
            {
                Console.WriteLine("Choose a name to find its position in the list and the position of its match.");
                foreach (string name in names2)
                {
                    Console.WriteLine(name);
                }
                userInput = Console.ReadLine();
                userInput.ToLower();

                for (int i = 0; i <= names2.Count; i++)
                {
                    foreach (string name in names2)
                    {
                        if (name.ToLower() == userInput)
                        {
                            Console.WriteLine("The index of " + userInput + " is " + names2.IndexOf(name, i));
                            Console.WriteLine(i.ToString());
                            stop = true;
                        }
                        //else if (i == names2.LastIndexOf(name))
                        //{
                        //    stop = true;

                        //}
                    }
                }
                if (!stop)
                {
                    Console.WriteLine("That name is not on the list, please try again \n");
                }
            }
        }
    }
}
