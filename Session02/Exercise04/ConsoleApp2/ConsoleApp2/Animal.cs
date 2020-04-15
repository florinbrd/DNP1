using System;

namespace ConsoleApp2
{
    public class Animal : IComparable<Animal>
    {
        private int Speed { get; set; }
        private double Weight { get; set; }

        public Animal(int speed, double weight)
        {
            Speed = speed;
            Weight = weight; 
        }
        

        public override string ToString()
        {
            return $"speed: {Speed}, weight: {Weight}";
        }

        public int CompareTo(Animal obj)
        {
            return this.Speed.CompareTo(obj.Speed);
        }

        
    }
}