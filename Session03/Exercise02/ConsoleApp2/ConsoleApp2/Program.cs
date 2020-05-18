using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() {1,2,3,4,5};

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("Random");
            Console.WriteLine(list.getRandom());
            
            Console.WriteLine("Shuffle");
            list.Shuffle();
            
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}