namespace ConsoleApp2
{
    public class Car
    {
        public string color;
        public string engine;
        public string fuelEconomy;

        public Car(string color, string engine, string fuelEconomy)
        {
            this.color = color;
            this.engine = engine;
            this.fuelEconomy = fuelEconomy; 
        }

        public override string ToString()
        {
            return $"Color: {color}, engine: {engine}, fuelEconomy: {fuelEconomy}";
        }
    }
}