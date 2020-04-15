using System;

namespace ConsoleApp2
{
    public abstract class Employee
    {
        private String name;

        public Employee(string name)
        {
            this.name = name; 
        }

        public abstract double getMonthlySalary();
    }
}