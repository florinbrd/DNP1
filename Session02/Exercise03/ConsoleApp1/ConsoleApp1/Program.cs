using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            
            company.addNewEmployee(new FullTimeEmployee("George", 200));
            company.addNewEmployee(new PartTimeEmployee("Esperanza", 200, 200));
            
            Console.WriteLine(company.getMonthlySalary());
            
            var student = new PartTimeStudent("Lola", 200, 200);
            student.Register(1997);
            company.addNewEmployee(student);

            Console.WriteLine(company.getMonthlySalary());
        }
    }
}