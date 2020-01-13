using System;
using System.Collections.Generic;


namespace Keywords
{
    public class PhoneBook
    {
        public PhoneBook(string name) : this(name, "0000000000")
        {

        }
        public PhoneBook(string name, string num)
        {
            Name = name;
            Num = num;
        }
        
        public string Name { get; set; }
        public string Num { get; set; }
        public Dictionary<string, string> DictionaryOfNums = new Dictionary<string, string>();

        public void Confirm(string name, string num)
        {
            DictionaryOfNums.Add(name, num);
            Console.WriteLine("The contact {0} with the phone number {1} has been saved to the contacts list.", name, num);

            foreach (KeyValuePair<string, string> kvp in DictionaryOfNums)
            {
                Console.WriteLine("PhoneBook:\nName: {0}\nNumber: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
