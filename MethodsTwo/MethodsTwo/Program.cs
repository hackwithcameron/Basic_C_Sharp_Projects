using System;

namespace MethodsTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum1;
            int userNum2;
            MathOnNumbers math = new MathOnNumbers();
            

            Console.WriteLine("Please enter a number:");
            userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number:");
            userNum2 = Convert.ToInt32(Console.ReadLine());
            math.A = userNum1;
            math.B = userNum2;
            MathOnNumbers.MathOne(math.A, math.B);

        }
    }
}
