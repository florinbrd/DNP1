using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nickname; 
            
            IDictionary<string, Person> dict = new Dictionary<string, Person>();

            dict.Add(new KeyValuePair<string, Person>("stupid", new Person("Florin", 100, 999999999)));
            dict.Add(new KeyValuePair<string, Person>("smart", new Person("Desi", 29, 2)));

            foreach (KeyValuePair<string, Person> item in dict)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            
            foreach (KeyValuePair<string, Person> item in dict)
            {
                if (item.Key == "stupid")
                {
                    Console.WriteLine(item.Value.ToString());
                }
            }
        }
    }
}