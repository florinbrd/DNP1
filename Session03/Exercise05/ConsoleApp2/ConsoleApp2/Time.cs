namespace ConsoleApp2
{
    public class Time
    {
        
        public int hours
        { get; set; }
        public int minutes { get; set; }


        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes; 
        }
        
        public static Time operator +(Time c1, Time c2)
        {
            return new Time(c1.hours + c2.hours, c1.minutes + c2.minutes); 
        }

        public override string ToString()
        {
            return $"Hours:{hours}, Minutes:{minutes}";
        }
    }
}