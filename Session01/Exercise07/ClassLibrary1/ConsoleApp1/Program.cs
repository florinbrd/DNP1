using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringUtility.SumUp("hello, this is my test so I will just go crazy 1 2 3 4 5 6 7 8 9 10");
        }
    }

    class StringUtility
    {
        public static string SumUp(string text)
        {
            string word = null; 
            
            if (text.Length >= 20)
            {
                word = text.Substring(0, 20) + "...";
                Console.WriteLine(word);
            }

            return word; 
        }
    }
}