using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath1 = "file1.txt";
            string filepath2 = "file2.txt";
            
            Reader s1 = new Reader(filepath1);
            Reader s2 = new Reader(filepath2);
            
            Thread t1 = new Thread(s1.Read);
            Thread t2 = new Thread(s2.Read);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            if (s1.Data.Length == s2.Data.Length)
            {
                if (s1.Data == s2.Data)
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
                Console.WriteLine("files are not the same ");
            }

        }
    }
}