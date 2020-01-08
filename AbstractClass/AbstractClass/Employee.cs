using System;
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

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (emp1.ID == emp2.ID)
            {
                return false;
            }
            return true;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (emp1.ID == emp2.ID)
            {
                return true;
            }
            return false;
        }
    }
}
