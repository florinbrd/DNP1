using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> inits = new Stack<int>();
            Stack<string> strings = new Stack<string>();
            
            inits.Push(1);
            inits.Push(1);
            inits.Push(1);
            
            strings.Push("mom");
            strings.Push("dad");
            strings.Push("brother");

            foreach (int i  in inits)
            {
                Console.WriteLine(i);
            }

            foreach (string j in strings)
            {
                Console.WriteLine(j);
            }
            
            
            PushToStack(inits, 1,3,4,5);
            PushToStack(strings, "damn", "sister", "god");
            
            foreach (int i  in inits)
            {
                Console.WriteLine(i);
            }

            foreach (string j in strings)
            {
                Console.WriteLine(j);
            }
        }

        private static void PushToStack<T>(Stack<T> stack, params T[] value)
        {
            foreach (T v in value)
            {
                stack.Push(v);
            }
        }
    }
}