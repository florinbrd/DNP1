using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          var animals = new List<Animal>
          {
              new Animal(200, 200), 
              new Animal(100, 150), 
              new Animal(400, 200)
          };
          
          animals.Sort();
          
          Console.WriteLine("Sorted..");

          foreach (Animal a in animals)
          {
           Console.WriteLine(a);   
          }
        }
    }
}