using System;

namespace MethodsFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum;
            int userNum2;
            decimal answer;
            MathOnNum math = new MathOnNum();


            Console.WriteLine("This is a Multiplication Calculator \n");
            Console.WriteLine("You will be asked to enter two numbers \n***First number times the Second number***");

            //First Number
            Console.WriteLine("What is your first number?");
            userNum = Convert.ToInt32(Console.ReadLine());


            try
            {
                //Second Number
                Console.WriteLine("What is your second number? Default is 1");
                userNum2 = Convert.ToInt32(Console.ReadLine());

                answer = math.Math(userNum, userNum2);
                Console.WriteLine(userNum + " times " + userNum2 + " = " + answer);
            }
            catch (Exception)
            {
                answer = math.Math(userNum);
                Console.WriteLine(userNum + " times 1 = " + answer);
            }
        }
    }
}
