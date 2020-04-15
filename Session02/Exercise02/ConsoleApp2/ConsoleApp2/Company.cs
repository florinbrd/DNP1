using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Company
    {
        private List<Employee> employees = new List<Employee>();

        public double GetMonthSalaryTotal()
        {
            double total = 0;

            foreach (Employee e in employees)
            {
                total += e.getMonthlySalary(); 
            }

            return total; 
        }

        public void EmployNewEmployee(Employee newEmployee)
        {
            employees.Add(newEmployee);
        }
    }
}