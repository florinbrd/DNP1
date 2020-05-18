using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("green",200, 2));
            cars.Add(new Car("yellow",50, 2));
            cars.Add(new Car("red",100, 1));

            static bool isGreenCar(Car car)
            {
                return car.color.Equals("green");
            }

            foreach (var c in cars.FindAll(isGreenCar))
            {
                Console.WriteLine(c);
            }
            
            foreach (var c in cars.FindAll( c => c.engine.Equals(200)))
            {
                Console.WriteLine(c);
            }
            
            foreach (var c in cars.FindAll( c => (c.engine.Equals(200)) && (c.color.Equals("green"))))
            {
                Console.WriteLine(c);
            }
        }
    }
}