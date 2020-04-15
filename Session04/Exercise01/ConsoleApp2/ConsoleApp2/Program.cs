using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            FindNumberOfWords();
            FindLongestWord();
        }

        static void FindNumberOfWords()
        {
            var wordCount = 0;

            try
            {
                using (var sr = new StreamReader("file.txt"))
                {
                    string line;
                  
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        wordCount += line.Split().Length;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Word count: {wordCount}");
        }

        static void FindLongestWord()
        {
            var longestWord = "";

            try
            {
                using(var sr = new StreamReader("file.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var words = line.Split();
                        foreach (var word in words)
                        {
                            if (word.Length > longestWord.Length)
                                longestWord = word;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Longest word: {longestWord}");
        }
    }
}
