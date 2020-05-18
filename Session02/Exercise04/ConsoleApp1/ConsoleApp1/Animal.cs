using System;

namespace ConsoleApp1
{
    public class Animal : IComparable<Animal>
    {
        public string type { get; set; }
        public double weight { get; set; }
        public int speed { get; set; }

        public Animal(string type, double weight, int speed)
        {
            this.type = type;
            this.weight = weight;
            this.speed = speed; 
        }

        public override string ToString()
        {
            return type + " " + weight + " " + speed; 
        }

        public int CompareTo(Animal other)
        {
            return this.speed.CompareTo(other.speed);
        }
    }
}