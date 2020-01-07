using System;
namespace MethodOutputParameter
{
    public static class DivideTwo
    {
        public static void Divide(int userNum)
        {
            Console.WriteLine(userNum + " Divided by 2 = " + (userNum / 2));
        }

        public static void Divide(out decimal userNum, out decimal userNum2, out decimal answer)
        {
            Console.WriteLine("Now choose two numbers to be divided into eachother");
            //Get users First number
            Console.WriteLine("Enter first number");
            userNum = Convert.ToDecimal(Console.ReadLine());
            //Get users Second number
            Console.WriteLine("Enter second number");
            userNum2 = Convert.ToDecimal(Console.ReadLine());

            answer = userNum / userNum2;
        }
    }
}
