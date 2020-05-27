using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Company
    {
        private List<Employee> employees= new List<Employee>();

        public double getMonthSalaryTotal()
        {
            double total = 0; 
            foreach (var emp in employees)
            {
                total += emp.getMonthlySalary();
            }

            return total; 
        }

        public void newEmployee(Employee emp)
        {
            employees.Add(emp);
        }
    }
}