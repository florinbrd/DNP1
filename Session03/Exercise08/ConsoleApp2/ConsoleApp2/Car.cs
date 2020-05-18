namespace ConsoleApp2
{
    public class Car
    {
        public string color { get; set;  }
        public int engine { get; set; }
        public int fulleconomy { get; set; }

        public Car(string color, int engine, int fulleconomy)
        {
            this.color = color;
            this.engine = engine;
            this.fulleconomy = fulleconomy; 
        }

        public override string ToString()
        {
            return color + " " + engine + " " + fulleconomy; 
        }
    }
}