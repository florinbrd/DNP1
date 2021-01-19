using System;

namespace ConsoleApp2
{
    public class Bomb:IExplodable<double>
    {
        public void Explode(double radius)
        {
            Console.WriteLine("BOOOM");
            Console.WriteLine(radius);
        }

      
    }
}