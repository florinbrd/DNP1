namespace ConsoleApp1
{
    public class PartTimeEmployee : Employee
    {
    private double hourWage;
    private double hoursPerMoth;

    public PartTimeEmployee(string name, double hourWage, double hoursPerMoth) : base(name)
    {
        this.hourWage = hourWage;
        this.hoursPerMoth = hoursPerMoth; 
    }

    public override double getMonthlySalary()
    {
        return hourWage * hoursPerMoth;
    }
    }
}