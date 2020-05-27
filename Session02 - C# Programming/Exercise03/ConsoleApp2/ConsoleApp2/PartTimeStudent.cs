namespace ConsoleApp2
{
    public class PartTimeStudent : PartTimeEmployee, IStudent
    {

        public double year { get; set; }
        
        public PartTimeStudent(string Name, double hours, double pay) : base(Name, hours, pay)
        {
        }

        public void Register(int year)
        {
            this.year = year; 
        }
    }
}