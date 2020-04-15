using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> dictionary = new Dictionary<string, Person>();
            
            var e = new Person("Florin", 200);
            var f = new Person("Bobo", 200);
            
            dictionary.Add("sucker", e);
            dictionary.Add("bomb", f);
            
            Console.WriteLine(dictionary["sucker"].ToString());
            
        }
    }
}