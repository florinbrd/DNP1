//Write a program that uses a switch-case structure. The program should take a number between 0 and 10. 
//If the number is 0, print “this is the first number” to the console. 
//If the number is 10, the program should write “this is the last number”.
//In any other case, the program should print the number provided. 
//(unless the number is not between 0 and 10, in which case it should output “invalid number”).


using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user, please enter a number: ");
            var number = Convert.ToInt64(Console.ReadLine());

            switch (number)
            {
                case 0:
                    Console.WriteLine("This is the first number: " + number);
                    break;
                case 10:
                    Console.WriteLine("This is the last number: " + number);
                    break;
                case 1: case 2: case 3: case 4: case 5: 
                    case 6: case 7: case 8: case 9: 
                    Console.WriteLine("Your number is " + number);
                    break; 
                default:
                    Console.WriteLine("You entered the wrong number ");
                    break;
            }
        }
    }
}