using System;

namespace ConsoleApp2
{
    public class Gun
    {
        private static int gunCount;
        private static int bulletCount;
        private int shotsFired { get; set;  }

        public Gun()
        {
            gunCount++;
        }

        public int getShotsFired()
        {
            return shotsFired; 
        }

        public void shoot()
        {
            Console.WriteLine("BANG BANG");
            bulletCount++;
            shotsFired++;

        }

        public void gunCheck()
        {
            Console.WriteLine("You have created:" + gunCount + "guns");
            Console.WriteLine("You have shot : " + bulletCount);
        }
    }
}