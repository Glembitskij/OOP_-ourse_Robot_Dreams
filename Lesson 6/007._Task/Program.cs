Developer developer = new Developer();
Manager manager = new Manager();

Life(developer, manager);

static void Life(params IEmployee[] employees)
{
    foreach (var employee in employees)
    {
        employee.Life(); // Виклик методу Life() для кожного працівника, який реалізує інтерфейс IEmployee
    }
}

internal interface IEmployee
{
    void Life(); // Метод, що визначений в інтерфейсі IEmployee
}

class Developer : IEmployee
{
    public void Life()
    {
        Console.WriteLine("Developer life"); // Реалізація методу Life() для класу Developer
    }
}

class Manager : IEmployee
{
    public void Life()
    {
        Console.WriteLine("Manager life"); // Реалізація методу Life() для класу Manager
    }
}
