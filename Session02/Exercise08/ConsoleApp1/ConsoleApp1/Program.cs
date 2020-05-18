using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var gun1 = new Gun();
            var gun2 = new Gun();
            var gun3 = new Gun();
            
            gun2.shoot();
            gun3.shoot();
            
            gun1.gunCheck();
            
        
        }
    }
}