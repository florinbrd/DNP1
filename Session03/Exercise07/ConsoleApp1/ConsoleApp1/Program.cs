using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notifier greetings = sayHello;
            greetings("boy");

            Notifier goodbye = sayGoodBye;
            goodbye("girl");

            Notifier both = greetings + goodbye;
            both("world");

        }

        delegate void Notifier(string message);

        public static void sayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public static void sayGoodBye(string name)
        {
            Console.WriteLine($"Goodbye {name}");
        }

    }
    
    
}