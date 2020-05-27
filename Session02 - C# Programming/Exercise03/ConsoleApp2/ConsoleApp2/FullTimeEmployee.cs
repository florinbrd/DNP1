namespace ConsoleApp2
{
    public class FullTimeEmployee : Employee
    
    {    
        public double monthlySalary { get; set; }
        
        public FullTimeEmployee(string Name, double monthlySalary) : base(Name)
        {
            this.monthlySalary = monthlySalary;
        }

        public override double getMonthlySalary()
        {
            return monthlySalary; 
        }
    }
}