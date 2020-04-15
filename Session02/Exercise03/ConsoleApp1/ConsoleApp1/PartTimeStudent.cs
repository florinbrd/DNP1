namespace ConsoleApp1
{
    public class PartTimeStudent: PartTimeEmployee, Istudent
    {
        private int startOfEducation; 
        
        public PartTimeStudent(string name, double hourWage, double hoursPerMoth) : base(name, hourWage, hoursPerMoth)
        { 
        }

        public void Register(int year)
        {
            startOfEducation = year; 
        }
    }
}