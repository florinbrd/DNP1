using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Player();
            var e = new Enemy();
            e.Damage = 200; 
            
            p.shout("Hello");
            p.shout(12);
            p.shout(e);
        }
    }
}