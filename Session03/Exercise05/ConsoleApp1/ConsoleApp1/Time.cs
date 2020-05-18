namespace ConsoleApp1
{
    public class Time
    {
        public int hour { get; set; }
        public int minutes { get; set; }

        public Time(int hour, int minutes)
        {
            this.hour = hour;
            this.minutes = minutes; 
        }
        
        public static Time operator+(Time c1, Time c2){
            return new Time(c1.hour + c2.hour, c1.minutes + c2.minutes);
        }

        public override string ToString()
        {
            return hour + " " + minutes; 
        }
    }
    
   
}