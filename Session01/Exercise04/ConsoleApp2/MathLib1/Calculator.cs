using System;
using System.Diagnostics.SymbolStore;
using System.Net.Sockets;

namespace MathLib1
{
    namespace Calculator
    {
        public class Calculator
        {
            public static int Add(int i, int j)
            {
                var sum = i + j;
                return sum; 
            }

            public static void Add(int[] numbers)
            {
                var sum = 0;
                for (var i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }

                Console.WriteLine("Your sum of array elements is: " + sum);
            }
        }
    }
}