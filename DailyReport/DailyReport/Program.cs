using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            string posExp;
            string feedBack;
            string course;
            string userInput;
            bool helpNeeded;
            ushort pageNum;
            float studyHours;



            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            course = Console.ReadLine();

            Console.WriteLine("What page number?");
            userInput = Console.ReadLine();
            pageNum = Convert.ToUInt16(userInput);

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            userInput = Console.ReadLine();
            helpNeeded = Convert.ToBoolean(userInput);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            posExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            feedBack = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            userInput = Console.ReadLine();
            studyHours = Convert.ToSingle(userInput);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.WriteLine(course);
            Console.WriteLine(pageNum);
            Console.WriteLine(helpNeeded);
            Console.WriteLine(posExp);
            Console.WriteLine(feedBack);
            Console.WriteLine(studyHours);
            Console.Read();
        }
    }
}
