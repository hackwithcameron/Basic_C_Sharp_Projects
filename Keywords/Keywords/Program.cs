using System;


namespace Keywords
{
    class Program
    {
        static void Main(string[] args)
        {
            const string appName = "FoneBook";
            string num;
            string userInput;

            Console.WriteLine("Welcome to {0}", appName);
            Console.WriteLine("What is the name of the contact you would like to save?");
            userInput = Console.ReadLine();
            Console.WriteLine("What is the phone number of the contact you would like to save?");
            num = Console.ReadLine();

            var contact = new PhoneBook(userInput, num);
            contact.Confirm(contact.Name, contact.Num);
            
        }
    }
}
