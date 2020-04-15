using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var gun1 = new Gun();
            var gun2 = new Gun();
            
            gun1.shoot();
            gun2.shoot();
            
          Console.WriteLine(gun1.getShotsFired());
          
          gun1.gunCheck();
        }
    }
}