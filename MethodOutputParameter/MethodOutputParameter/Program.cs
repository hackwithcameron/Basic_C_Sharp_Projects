using System;

namespace MethodOutputParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum;
            decimal userNum1;
            decimal userNum2;
            decimal answer;



            Console.WriteLine("Please enter a number to be divided by 2");
            userNum = Convert.ToInt32(Console.ReadLine());
            DivideTwo.Divide(userNum);

            
            DivideTwo.Divide(out userNum1, out userNum2, out answer);
            Console.WriteLine(userNum1 + " Divided by " + userNum2 + " = " + answer);
        }
    }
}
