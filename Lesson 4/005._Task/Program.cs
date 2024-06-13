
Developer developer = new Developer() 
{
    Name = "Alex",
    Age = 30, 
    ProgramLanguage = "C#"
};

Manager manager = new Manager()
{
    Name = "Vasa",
    Age = 20,
    Category = "program"
};

// UpCats
Employee employeeDev = (Employee)developer;
Employee employeeMan = (Employee)manager;

AllEmployeeIntroduce(employeeDev, employeeMan);

static void AllEmployeeIntroduce(params Employee[] employees)
{
    foreach (Employee employee in employees)
    {
        employee.Introduce();
    }
}

internal class Employee
{
    public string? Name { get; set; }

    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"{Name} - {Age}");
    }
}


internal class Developer : Employee
{
    public string? ProgramLanguage { get; set; }
}

internal class Manager: Employee
{
    public string? Category { get; set; }
}