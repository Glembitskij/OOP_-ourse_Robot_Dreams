
Employee employee = new Employee();
employee.Name = "Alex";
//employee.LastName;
//employee.Salary;

Developer developer = new Developer();
developer.Name = "Vasa";
//developer.LastName;
//developer.Salary;

developer.ShowBaseInfo();

developer.ChengeBaseInfo();
Console.WriteLine(new string('-', 20));
developer.ShowBaseInfo();

internal class Employee
{
    public string? Name;

    protected string? LastName = "Shevchenko";

    private int Salary; 
}

class Developer: Employee
{
    public void ShowBaseInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine(LastName);
        //Console.WriteLine(Salary);
    }

    public void ChengeBaseInfo()
    {
        Name = "Peta";
        LastName = "Ivanov";
        //Salary = 100;
    }
}
