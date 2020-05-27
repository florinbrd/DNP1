using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Odd number: {i} ");
                }
            }


            int j = 0;
            while (j <= 100)
            {
                if (j % 2 == 1)
                {
                    Console.WriteLine($"Uneven number: {j}");
                }

                j++;
            }
        }
    }
}