using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 42;
           

            string message = score > 100 ? "This is nice" : "This is not nice";
            
            Console.WriteLine(message);
        }
    }
}