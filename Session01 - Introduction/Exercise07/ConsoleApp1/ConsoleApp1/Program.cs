using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number 2:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Max number is: {Math.Max(a, b)}");
        }
    }
}