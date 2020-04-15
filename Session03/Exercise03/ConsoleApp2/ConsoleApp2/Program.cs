using System;
using System.Collections.Generic;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           Stack<int> ints = new Stack<int>();
           Stack<string> stack = new Stack<string>();
           
           
           ints.Push(1);
           ints.Push(2);
           ints.Push(3);
           
           stack.Push("hello");
           stack.Push("goodbye");
           stack.Push("welcome");
           
           

           foreach (int i in ints)
           {
               Console.WriteLine(i);
           }

           foreach (string i in stack)
           {
               Console.WriteLine(i);
           }

           pushToStack(ints, 1,2,3,4,5);
           pushToStack(stack, "hello", "hello again");
           
           foreach (int i in ints)
           {
               Console.WriteLine(i);
           }

           foreach (string i in stack)
           {
               Console.WriteLine(i);
           }

        }

        private static void pushToStack<T>(Stack<T> stack, params T[] values)
        {
            foreach (T value in values)
            {
                stack.Push(value);
            }
        }
    }
}