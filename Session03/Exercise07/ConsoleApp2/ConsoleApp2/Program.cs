using System;

  //  Create a Notifier delegate that takes a string as an argument and returns void. Implement two methods, SayHello and SayGoodbye that prints "Hello [name]" and "Goodbye [name]",
//respectively, to the console. The methods should be compatible with the Notifier delegate.

//Use the Notifier delegate to first print "Hello [name]" to the console when the application is run. Next, modify the code so that "Goodbye [name]" 
//is printed instead. Lastly, modify and add to the code so that "Hello [name]" and "Goodbye [name]" are both printed to the console.

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Notifier greetings = sayHello;
            greetings("boy");
            greetings = sayGoodBye;
            greetings("girl");

            greetings += sayHello;
            greetings("world");

        }

        delegate void Notifier(string message);

        public static void sayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public static void sayGoodBye(string name)
        {
            Console.WriteLine($"Good-bye {name}");
        }


    }
}