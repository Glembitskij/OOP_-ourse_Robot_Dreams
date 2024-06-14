Developer developer = new Developer();
developer.Life();
developer.Work();
developer.DrinkCoffe();

IEmployee employee = developer;
employee.Work();

IPerson person = developer;
developer.DrinkCoffe();

Object obj = developer;

internal interface IPerson
{
    void Life();
}

internal interface IEmployee
{
    void Work();
}

class Developer : Object, IPerson, IEmployee
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
