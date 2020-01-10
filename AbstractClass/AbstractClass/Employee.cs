using System;
using System.Collections.Generic;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {

        public int ID { get; set; }
        

        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("Employee Quits");
        }
    }
}
