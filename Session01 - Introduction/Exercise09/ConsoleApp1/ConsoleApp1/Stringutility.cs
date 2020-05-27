using System;

namespace ConsoleApp1
{
    public class Stringutility
    {
        public void summarize(string text)
        {
            var returnString = "";
                
            if (text.Length > 20)
            {
                returnString = text.Substring(0, 20) + "...";
            }

            Console.WriteLine($"Summarized string: {returnString}");
        }
    }
}