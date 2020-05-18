using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            var dnpStudent = new DNPStudent();
            
            student.sayHi();
            dnpStudent.sayHi();

            var dnp = (Student) dnpStudent;
            dnp.sayHi(); // child version is being called 
        }
    }
}