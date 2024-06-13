Employee employee = new Employee();
employee.GetInfo();

Developer developer = new Developer();
developer.GetInfo();

Employee employeeDev = developer;
employeeDev.GetInfo();

Developer developerAgain = (Developer)employeeDev;
developerAgain.GetInfo();

internal class Employee
{
    public void GetInfo()
    {
        Console.WriteLine("Employee");
    } 
}

internal class Developer : Employee
{
    public new void GetInfo()
    {
        Console.WriteLine("Employee");
    }
}
