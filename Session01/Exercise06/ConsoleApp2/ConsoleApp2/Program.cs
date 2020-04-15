//Write a program that asks the user to enter their name.
//Use an array to reverse the name and then store the result in a new string.
//Display the reversed name on the console.

using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me your name ");
            var reverseName = Console.ReadLine().ToCharArray();
            Array.Reverse(reverseName);

            var temp = new string(reverseName);
            Console.WriteLine("Reversed name: " + temp);
            
        }
    }
}