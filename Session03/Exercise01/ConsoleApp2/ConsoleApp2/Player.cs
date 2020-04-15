using System;

namespace ConsoleApp2
{
    public class Player
    {
        public void Shout(string word)
        {
            Console.WriteLine("You wanna shout: " + word);
        }

        public void Shout(int number)
        {
            Console.WriteLine("This is your lucky number: " + number);
        }

        public void Shout(Enemy e)
        {
            Console.WriteLine("Enemy can do this damage to you: " + e.damage);
        }
    }
}