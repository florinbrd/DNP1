using System;
using System.ComponentModel;
using System.IO;
using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            findNumberOfWords();
            findLongestWord();
        }

        static void findNumberOfWords()
        {
            var count = 0; 
            var sr = new StreamReader("/Users/florinbordei/Desktop/DNP1.1/Session04/Exercise01/ConsoleApp1/ConsoleApp1/file.txt");
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                count += line.Split().Length;
            }
            
            Console.WriteLine($"Word count: {count}");
        }

        static void findLongestWord()
        {
            var sr = new StreamReader(
                "/Users/florinbordei/Desktop/DNP1.1/Session04/Exercise01/ConsoleApp1/ConsoleApp1/file.txt");
            string longestWord = "";
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                var words = line.Split();
                
                foreach (var var in words)
                {
                    if (var.Length > longestWord.Length)
                    {
                        longestWord = var; 
                    }
                }
            }
            Console.WriteLine($"The longest word is {longestWord}");
        }
    }
}