using System;
using System.Collections.Generic;

namespace AbstractClass
{
    public class Employee<T> : Person, IQuittable
    {

        public int ID { get; set; }
        public List<T> Things { get; set; }

        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("Employee Quits");
        }



        //********* Compairs Employees using IDs *********

        //public static bool operator ==(Employee emp1, Employee emp2)
        //{
        //    if (emp1.ID == emp2.ID)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public static bool operator !=(Employee emp1, Employee emp2)
        //{
        //    if (emp1.ID == emp2.ID)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
