Developer developer = new Developer();
//developer.Work();

IPerson person = developer;
person.Work();

IEmployee employee = developer;
employee.Work();

internal interface IPerson
{
    void Work();
}

internal interface IEmployee
{
    void Work();
}

internal class Developer : IPerson, IEmployee
{
    void IPerson.Work()
    {
        Console.WriteLine("IPerson work");
    }

    void IEmployee.Work()
    {
        Console.WriteLine("IEmployee work");
    }
}