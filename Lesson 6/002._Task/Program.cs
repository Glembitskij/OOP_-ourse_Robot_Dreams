Manager manager = new Manager();
manager.DoWork();
manager.DrinkCoffe();
int managerSalary = manager.GetSalary();
Console.WriteLine(managerSalary);

Developer developer = new Developer();
developer.DoWork();
developer.DrinkCoffe();
int developerSalary = developer.GetSalary();
Console.WriteLine(developerSalary);

internal abstract class Employee
{
    public abstract void DoWork();

    public virtual int GetSalary()
    {
        return new Random().Next(1, 10);
    }

    public void DrinkCoffe()
    {
        Console.WriteLine("Employee drink coffe");
    }
}

internal class Developer : Employee
{
    public override void DoWork()
    {
        Console.WriteLine("Developer write code");
    }

    public override int GetSalary()
    {
        return base.GetSalary() + 100;
    }
}

internal class Manager : Employee
{
    public override void DoWork()
    {
        Console.WriteLine("Manager do work");
    }
}