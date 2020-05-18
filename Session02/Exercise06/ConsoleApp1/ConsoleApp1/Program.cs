using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           var schedule = new Schedule();

           schedule[new DateTime(2000, 12, 20)] = "Dnp";
           schedule[new DateTime(2001, 10, 10)] = "Dnp2";
           
           Console.WriteLine(schedule["2000-12-20"]);
        }
    }
}