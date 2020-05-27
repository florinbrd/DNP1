using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Company();
            var empfull = new FullTimeEmployee("Test1", 200);
            var partTime = new PartTimeEmployee("Test2", 20, 20);
            
            company.newEmployee(empfull);
            company.newEmployee(partTime);
            
            Console.WriteLine(company.getMonthSalaryTotal());
            
            company.newEmployee(new FullTimeEmployee("Test3", 200));
            
            Console.WriteLine(company.getMonthSalaryTotal());
        }
    }
}