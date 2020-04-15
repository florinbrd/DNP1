
//Write a program that prints all even numbers between 0 and 100 using a for loop. Next, create a while loop that prints all the uneven numbers.

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Your even number: " + i);
                }
            }

            int unevenNumber = 0;

            while (unevenNumber < 100)
            {
                if (unevenNumber % 2 == 1)
                {
                    Console.WriteLine("Your uneven number is: " + unevenNumber);
                }

                unevenNumber++; 
            }
        }
    }
}