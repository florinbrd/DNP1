using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath1 = "file1.txt";
            string filepath2 = "file.txt";
            Reader s = new Reader(filepath1);
            Reader t = new Reader(filepath2);

            Thread t1 = new Thread(s.Read);
            Thread t2 = new Thread(t.Read);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            if (s.Data.Length == t.Data.Length)
            {
                if (s.Data == t.Data)
                {
                    Console.WriteLine("Files are the same");
                }
                else
                {
                    Console.WriteLine("Files are not the same");
                }
            }
            else
            {
                Console.WriteLine("Files are not the same");
            }
        }
    }
}