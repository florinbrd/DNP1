using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new List<int>() {1,2,3,4};
            
            Console.WriteLine("List: ");

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("Random Elements from list: " + ints.getRandom());
            ints.Shuffle();
            Console.WriteLine("Shuffled list: ");
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}