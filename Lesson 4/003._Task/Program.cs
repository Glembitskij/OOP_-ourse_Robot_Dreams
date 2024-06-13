
Developer developer = new Developer();

Console.WriteLine(developer.Age); // 0

internal class Employee
{
    public string? Name { get; set; }

    public string? LastName { get; set; }
    
    public int Age { get; set; }

    public Employee()
    {
        Name = default;
        LastName = default;
        Age = default;
    }
}


internal class Developer: Employee
{
    public string? ProgramLanguage { get; set; }

    public Developer()
    {
        ProgramLanguage = default;
    }
}