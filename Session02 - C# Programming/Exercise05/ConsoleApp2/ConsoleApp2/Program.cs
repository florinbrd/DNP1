using System;
using Funny;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clown c1 = new Clown("T");
            Clown c2 = new Clown("F");
            Clown c3 = new Clown("C");
            
            Console.WriteLine(c1.Name);
            Console.WriteLine(c2.Name);
            Console.WriteLine(c3.Name);
        }
    }
}