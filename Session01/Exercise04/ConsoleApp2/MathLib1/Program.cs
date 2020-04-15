using System;

namespace MathLib1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathLib1.Calculator.Calculator.Add(1,2));
            
            MathLib1.Calculator.Calculator.Add(new int[]{2,3,4});
        }
    }
}