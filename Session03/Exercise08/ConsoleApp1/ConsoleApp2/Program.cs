using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("green", "400", "300"));
            cars.Add(new Car("red", "200", "300"));
            cars.Add(new Car("yellow", "200", "300"));
            cars.Add(new Car("black", "200", "300"));

            static bool greenCarCheck(Car car)
            {
                return car.color.Equals("green");
            }

            foreach (Car c in cars.FindAll(greenCarCheck))
            {
                Console.WriteLine(c);
            }
            
            Console.WriteLine(".........");
            

            foreach (Car c in cars.FindAll(c => c.engine.Equals("200")))
            {
                Console.WriteLine(c);
            }
        }
    }
}