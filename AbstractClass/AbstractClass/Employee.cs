using System;
namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
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
