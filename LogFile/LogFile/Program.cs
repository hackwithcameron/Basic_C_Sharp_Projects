using System;
using System.IO;

namespace LogFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Askes user for number to log.
            Console.WriteLine("Please enter a number to be logged");
            string num = Console.ReadLine();
            //Path to location of log file.
            string filePath = @"C:/log/log.txt";
            //Adding number to file on new line. If no file exists a new file is created.
            File.AppendAllText(filePath, "\n" + num);
            //Gets all text from file and prints to console.
            string response = File.ReadAllText(filePath);
            Console.WriteLine("Log: {0}", response);
        }
    }
}
