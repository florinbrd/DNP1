namespace ConsoleApp2
{
    public class PartTimeEmployee : Employee
    {

        private double hourlyWage;
        private double hoursPerMotnh; 
        
        public PartTimeEmployee(string name, double hourlyWage, double hoursPerMotnh) : base(name)
        {
            this.hourlyWage = hourlyWage;
            this.hoursPerMotnh = hoursPerMotnh; 
        }
        
        public override double getMonthlySalary()
        {
            return hourlyWage * hoursPerMotnh; 
        }

       
    }
}