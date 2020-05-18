using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>
            {
                new Animal("tiger", 200, 200), 
                new Animal("pig", 400, 50),
                new Animal("bird", 10, 400)
            };
            
            Console.WriteLine("Not sorted");

            foreach (var e in animals)
            {
                Console.WriteLine(e.ToString());
            }
            
            animals.Sort();
            
            Console.WriteLine("Sorted");
            foreach (var e in animals)
            {
                Console.WriteLine(e.ToString());
            }
            
        }
    }
}