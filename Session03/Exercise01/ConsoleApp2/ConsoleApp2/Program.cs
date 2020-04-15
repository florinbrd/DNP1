using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e = new Enemy();
            e.damage = 200; 
            
            Player og = new Player();
            
            og.Shout("hello");
            og.Shout(1);
            og.Shout(e);
            
        }
    }
}