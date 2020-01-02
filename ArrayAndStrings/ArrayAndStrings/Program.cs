using System;
using System.Collections.Generic;

namespace ArrayAndStrings
{
    class Program
    {
        static void Main()
        {
            string userInput;
            int index;
            string[] strArray = { "Jack", "Jill", "John", "Doe?" };
            int[] intArray = { 1, 24, 63, 154, 367 };
            bool stop;
            List<string> strList = new List<string>();
            strList.Add("Very nice dude, this is the end of the program.");
            strList.Add("Far out man, you made it to the end Congrats!!");
            strList.Add("Whoop, whoop! You did it!!!");
            strList.Add("I've seen people do it quicker... but very nice!!! You're all done.");


            stop = false;

            while (!stop)
            {
                Console.WriteLine("Lets get a name from the array, choose a number");
                userInput = Console.ReadLine();
                index = Convert.ToInt32(userInput);

                if (index <= strArray.Length)
                {
                    //For index accuracy
                    index = index - 1;
                    Console.WriteLine("You picked the name " + strArray[index]);

                    //Pick a number from the array
                    while (!stop)
                    {
                        Console.WriteLine("Now lets pick a number from the array, choose another number");
                        userInput = Console.ReadLine();
                        index = Convert.ToInt32(userInput);

                        if (index <= intArray.Length)
                        {
                            index = index - 1;
                            Console.WriteLine("You picked the number " + intArray[index]);

                            //Pick a number from the array
                            while (!stop)
                            {
                                Console.WriteLine("Lastly a string from a list, choose one more number");
                                userInput = Console.ReadLine();
                                index = Convert.ToInt32(userInput);

                                if (index <= strList.Count)
                                {
                                    index = index - 1;
                                    Console.WriteLine("You picked the number " + strList[index]);
                                    stop = true;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Whoa buddy! Still too great of a number for this array, try something between 1 and 5");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That number is much too great for this array, try something between 1 and 4");
                }
            }
        }
    }
}
