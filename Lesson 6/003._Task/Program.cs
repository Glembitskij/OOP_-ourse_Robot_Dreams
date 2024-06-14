
Developer developer = new Developer();
Console.WriteLine(developer.Age); // ?

internal abstract class Employee
{
    public string? Name { get; set; }

    public int Age { get; set; }

    public Employee()
    {
        Name = default;
        Age = default;
    }
}

internal class Developer : Employee
{
    public int ProgramLanguage { get; set; }

    public Developer()
    {
        ProgramLanguage = default;
    }
}