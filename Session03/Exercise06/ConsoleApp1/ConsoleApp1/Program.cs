using System;
//rewrite code in terneray 

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 42;
            string message;

            if (score > 1337)
            {
                message = "This is a high score"; 
            }
            else
            {
                message = "You need more points"; 
            }
            
            Console.WriteLine(message);
            
            // terneray 

           var result  = score > 1337 ? message = "this is a high score " : message = "this is not a highscore";
            Console.WriteLine(result);

        }
    }
}