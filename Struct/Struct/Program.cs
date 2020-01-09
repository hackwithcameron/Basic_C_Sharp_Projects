using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number() { Amount = 3.14m };
            

            Console.WriteLine(number.Amount);
        }
    }
}
