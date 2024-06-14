Developer developer = new Developer();
developer.Life();
developer.Work();
developer.DrinkCoffe();

IEmployee employee = developer;
employee.Work();
employee.Life();

IPerson person = developer;
person.Life();

internal interface IPerson
{
    void Life();
}

internal interface IEmployee: IPerson
{
    void Work();
}

class Developer : IEmployee
{
    public void Life()
    {
        Console.WriteLine("Developer life");
    }

    public void Work()
    {
        Console.WriteLine("Developer work");
    }

    public void DrinkCoffe()
    {
        Console.WriteLine("Developer drink coffe");
    }
}