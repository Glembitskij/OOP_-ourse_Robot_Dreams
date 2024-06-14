//Employee employee = new Employee();

Manager manager = new Manager();
Developer developer = new Developer();

StartWork(manager, developer);

static void StartWork(params Employee[] employees)
{
    foreach (Employee employee in employees)
    {
        employee.DoWork();

        if (employee is Developer)
        {
            Developer developer = (Developer)employee;
            developer.DrinkCoffe();
        }
    }
}

internal abstract class Employee
{
    public abstract void DoWork();
}

internal class Developer : Employee
{
    public override void DoWork()
    {
        Console.WriteLine("Developer write code");
    }

    public void DrinkCoffe()
    {
        Console.WriteLine("Developer drink coffe");
    }
}

internal class Manager : Employee
{
    public override void DoWork()
    {
        Console.WriteLine("Manager do work");
    }
}