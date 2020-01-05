using System;
using System.Collections.Generic;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum;
            List<int> nums = new List<int> { 3, 6, 8, 14, 53, 61, 128 };
            decimal answer;
            bool stop;

            stop = false;


            while (!stop)
            {
                try
                {
                    Console.WriteLine("Please enter a number to be divided by ");
                    foreach (int num in nums)
                    {
                        Console.Write(num + ", ");
                        if (nums.IndexOf(num) == nums.Count - 1)
                        {
                            Console.Write("\n>>>  ");
                        }
                    }
                    userNum = Convert.ToInt32(Console.ReadLine());

                    foreach (int num in nums)
                    {
                        //Converts numbers to decimal so returned answer will be decimal
                        answer = Convert.ToDecimal(num) / userNum;
                        Console.WriteLine(num + " Divided by " + userNum + " = " + answer);
                        stop = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
            }
  
        }
    }
}
