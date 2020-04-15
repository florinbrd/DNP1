using System;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is ..." + Name);
        }
    }
}