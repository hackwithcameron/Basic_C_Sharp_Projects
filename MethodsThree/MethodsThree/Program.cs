using System;

namespace MethodsThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int userNum;
            int answer;
            decimal userNum2;
            decimal answer2;
            MathOnNum math = new MathOnNum();
            

            // First method adds 15 to int userInput
            Console.WriteLine("Enter a whole number");
            userNum = Convert.ToInt32(Console.ReadLine());
            answer = math.Math(userNum);
            Console.WriteLine(userNum + " Plus 15 = " + answer);

            // Second method Divideds decimal userInput by 25
            Console.WriteLine("Enter another number with decimal");
            userNum2 = Convert.ToDecimal(Console.ReadLine());
            answer2 = math.Math(userNum2);
            Console.WriteLine(userNum2 + " Divided by 25 = " + answer2);

            // Takes string userInput and returns int * 2
            Console.WriteLine("Enter one last whole number");
            userInput = Console.ReadLine();
            try
            {
                answer = math.Math(userInput);
                Console.WriteLine(userInput + " Times 2 = " + answer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
