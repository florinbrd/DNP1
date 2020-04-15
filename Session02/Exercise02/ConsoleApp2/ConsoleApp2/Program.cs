using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var partTtimeEmp1 = new PartTimeEmployee("George", 12, 20);
            var fullEmployee = new FullTimeEmployee("David", 200);
            
            Company company = new Company();
            company.EmployNewEmployee(partTtimeEmp1);
            company.EmployNewEmployee(fullEmployee);
            Console.WriteLine(company.GetMonthSalaryTotal());
            
            company.EmployNewEmployee(new PartTimeEmployee("Florin", 200, 200));

            Console.WriteLine(company.GetMonthSalaryTotal());

        }
    }
}