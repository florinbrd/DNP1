namespace ConsoleApp1
{
    public abstract class Employee
    {
        private string Name { get; set; }

        public Employee(string Name)
        {
            this.Name = Name; 
        }

        public abstract double getMonthlySalary();
    }
}