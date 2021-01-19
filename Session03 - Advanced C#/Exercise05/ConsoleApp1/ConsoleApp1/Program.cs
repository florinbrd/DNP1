using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(10, 10);
            Time t2 = new Time(15, 25);

            var t3 = t1 + t2; 
            
            Console.WriteLine(t3.ToString());
        }
    }
}