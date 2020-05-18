using System;

namespace ConsoleApp1
{
    public class Gun
    {
        private static int gunCount;
        private static int bulletCount;
        private int shotsFired;

        public Gun()
        {
            gunCount++;
        }

        public void shoot()
        {
            Console.WriteLine("BANG BANG");
            bulletCount++;
            shotsFired++; 
        }

        public void gunCheck()
        {
            Console.WriteLine($"You have created: {gunCount} this amount of guns");
            Console.WriteLine($"Bullet count: {bulletCount}");
            Console.WriteLine($"Shots fired: {shotsFired}");
        }
    }
}