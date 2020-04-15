namespace ConsoleApp2
{
    public class FullTimeEmployee : Employee
    {
        private double monthlySalary; 
        
        public FullTimeEmployee(string name, double monthlySalary) : base(name)
        {
            this.monthlySalary = monthlySalary; 
        }

        public override double getMonthlySalary()
        {
            return monthlySalary; 
        }

        
    }
}