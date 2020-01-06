using System;
namespace MethodsTwo
{
    public class MathOnNumbers
    {
        public MathOnNumbers()
        {
        }

        public int A { get; set; }
        public int B { get; set; }

        public static void MathOne(int A, int B)
        {
            int answer;
            answer = A * 2;
            Console.WriteLine("Second number is " + B);
            Console.WriteLine("First number " + "\"" + A + "\"" + " x 2 = " + answer);
        }
    }
}
