using System;

namespace ConsoleApp1
{
    public class Player
    {
        public void shout(string arg)
        {
            Console.WriteLine(arg);
        }
        
        public void shout(int arg)
        {
            Console.WriteLine(arg);
        }

        public void shout(Enemy e)
        {
            Console.WriteLine(e.Damage);
        }
    }
}