Developer developer = new Developer();
developer.DrinkCoffe();
developer.DoWork();
developer.Life();

Employee employee = developer;
employee.DoWork();
developer.Life();

Person person = developer;
person.Life();

internal class Person
{
    public void Life()
    {
        Console.WriteLine("Peson life");
    }
}

internal abstract class Employee: Person
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