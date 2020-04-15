//Write a program that takes two number inputs from the console and then displays the maximum of the two.
//(hint: use the Console.ReadLine() method).

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number 1: ");
            var numberOne = Convert.ToInt64(Console.ReadLine());
            
            Console.WriteLine("Number 2: ");
            var numberTwo = Convert.ToInt64(Console.ReadLine());
            
            Console.WriteLine(Math.Max(numberOne, numberTwo));
            
            
        }
    }
}