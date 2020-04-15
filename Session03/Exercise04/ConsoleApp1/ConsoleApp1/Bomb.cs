using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Bomb : IExplodable<double>
    {
        public void Explode(double radius)
        {
            Console.WriteLine("Boom/Boom" + radius);
        }
    }
}