using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var schedule = new Schedule();

            schedule[new DateTime(2019, 20, 20)] = "DNP lesson";
            schedule[new DateTime(2020, 20, 20)] = "DNP re-exam";

            Console.WriteLine(schedule["2020-20-20"]);
    }
    }
}