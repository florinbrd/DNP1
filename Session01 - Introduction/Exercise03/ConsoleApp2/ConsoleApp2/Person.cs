using System;

namespace ConsoleApp2
{
    public class Person
    {
        public string Name { get; set; }
        

        public void introduce(string Name)
        {
            Console.WriteLine($"Hello, my name is {Name}");
        }
    }
}