﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(10, 20);
            Time t2 = new Time(20, 21);

            var t3 = t1 + t2;

            Console.WriteLine(t3.ToString());


        }
    }
}