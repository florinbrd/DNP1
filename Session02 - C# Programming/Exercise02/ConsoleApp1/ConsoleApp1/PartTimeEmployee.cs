namespace ConsoleApp1
{
    public class PartTimeEmployee : Employee
    {
        public double hourlyWage { get; set; }
        public double hoursPerMonth { get; set; }
        
        public PartTimeEmployee(string Name, double hourlyWage, double hoursPerMonth) : base(Name)
        {
            this.hourlyWage = hourlyWage;
            this.hoursPerMonth = hoursPerMonth;
        }

        public override double getMonthlySalary()
        {
            return hourlyWage * hoursPerMonth;
        }
    }
}