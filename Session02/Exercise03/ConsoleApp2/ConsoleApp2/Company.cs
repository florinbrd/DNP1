using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Company
    {
        public List<Employee> employees = new List<Employee>();

        public double getMonthlySalary()
        {
            double total = 0;

            foreach (var emp in employees)
            {
                total += emp.getMonthlySalary();
            }

            return total; 
        }

        public void addNewEmployee(Employee emp)
        {
            employees.Add(emp);
        }
    }
}