using System;
using Mathlib2;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

            Console.WriteLine(calc.add(1,2));
            Console.WriteLine(calc.add(new []{1,2,3}));
        }
    }
}