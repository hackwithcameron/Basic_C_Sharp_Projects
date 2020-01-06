using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal userNum;
            MathForNum math = new MathForNum();
            decimal answer;
            decimal answer2;
            decimal answer3;


            Console.WriteLine("Welcome to my tip Calculator");
            Console.WriteLine("Enter bill total:");
            userNum = Convert.ToDecimal(Console.ReadLine());
            answer = math.MathOne(userNum);
            answer2 = math.MathTwo(userNum);
            answer3 = math.MathThree(userNum);
            Console.WriteLine("10% of " + userNum.ToString("C") + " is " + answer.ToString("C"));
            Console.WriteLine("15% of " + userNum.ToString("C") + " is " + answer2.ToString("C"));
            Console.WriteLine("20% of " + userNum.ToString("C") + " is " + answer3.ToString("C"));
        }
    }
}
