Developer developer = new Developer();
Manager manager = new Manager();

Life(developer, manager);

static void Life(params IEmployee[] employees)
{
    foreach (var employee in employees)
    {
        employee.Life();
    }
}

internal interface IEmployee
{
    void Life();
}

class Developer : IEmployee
{
    public void Life()
    {
        Console.WriteLine("Developer life");
    }
}

class Manager : IEmployee
{
    public void Life()
    {
        Console.WriteLine("Manager life");
    }
}