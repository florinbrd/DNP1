using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var comp = new Company();
            
            var emp = new FullTimeEmployee("Test1", 200);
            var empPart = new PartTimeEmployee("Test", 20, 20);
            var student = new PartTimeStudent("Test2", 20, 20);
            
            comp.addNewEmployee(emp);
            comp.addNewEmployee(empPart);
            comp.addNewEmployee(student);

            Console.WriteLine(comp.getMonthlySalary());
            
            student.Register(2000);
            Console.WriteLine(student.year);
        }
    }
}