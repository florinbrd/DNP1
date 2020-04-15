using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            var dnpStudent = new DNPStudent();
            
            student.sayHi();
            dnpStudent.sayHi();
            
            Console.WriteLine(".........");

            student = dnpStudent; 
            student.sayHi();
            dnpStudent.sayHi();

        }
    }

    
}