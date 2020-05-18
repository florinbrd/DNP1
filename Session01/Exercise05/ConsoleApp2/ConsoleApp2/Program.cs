using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell us a number: ");
            var j = Convert.ToInt64(Console.ReadLine());

            switch (j)
            {
                
                case 0: 
                Console.WriteLine("This is the first number");
                break;
            
            case 10: 
                Console.WriteLine("This is the last number");
                break;
            
            case 1: case 2: case 3: 
            case 4: case 5: case 6: 
            case 7: case 8: case 9:
                Console.WriteLine($"The provided number is {j}");
                break;
            
            default:
                Console.WriteLine("Invalid number");
                break;

            }
        }
    }
}