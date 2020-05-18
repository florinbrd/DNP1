using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me your name:");
            var name = Console.ReadLine().ToCharArray();

            Array.Reverse(name);
            var reversedName = new string(name);
            Console.WriteLine($"Reversed name: {reversedName} ");

            // solution 2: 

            Console.WriteLine("Tell me your name:");
            var name2 = Console.ReadLine();
            string reverse = "";
            int length = name2.Length - 1;

            while (length >= 0)
            {
                reverse = reverse + name2[length];
                length--; 
            }
            
            Console.WriteLine($"Reversed name is {reverse}");

        }
    }
}