﻿Developer developer = new Developer();
developer.Work();
developer.Life();

Employee employee = developer;
employee.Work();
employee.Life();

IPerson person = developer;
person.Life();

public interface IPerson
{
    void Life();
}

abstract class Employee : IPerson
{
    public abstract void Work();

    public void Life() 
    {
        Console.WriteLine("Employee life");
    }
}

class Developer : Employee
{
    public override void Work()
    {
        Console.WriteLine("Developer Work");
    }
}

