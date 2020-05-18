namespace ConsoleApp2
{
    public class PartTimeEmployee : Employee
    {
        public double hours { get; set; }
        public double pay { get; set; }

        public PartTimeEmployee(string Name, double hours, double pay) : base(Name)
        {
            this.hours = hours;
            this.pay = pay; 
        }

        public override double getMonthlySalary()
        {
            return pay * hours; 
        }
    }
}