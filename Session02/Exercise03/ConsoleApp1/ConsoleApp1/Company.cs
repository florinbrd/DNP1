using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Company
    {
        private List<Employee> employees = new List<Employee>();

        public double getMonthlySalary()
        {
            double total = 0;

            foreach (Employee e in employees)
            {
                total += e.getMonthlySalary();
            }

            return total; 
        }

        public void addNewEmployee(Employee e)
        {
            employees.Add(e);
        }
    }
}