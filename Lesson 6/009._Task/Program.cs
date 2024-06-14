Developer developer = new Developer();
developer.Life(); // Виклик методу Life() класу Developer
developer.Work(); // Виклик методу Work() класу Developer
developer.DrinkCoffe(); // Виклик методу DrinkCoffe() класу Developer

IEmployee employee = developer;
employee.Work(); // Виклик методу Work() через інтерфейс IEmployee
employee.Life(); // Виклик методу Life() через інтерфейс IEmployee, успадкованого від IPerson

IPerson person = developer;
person.Life(); // Виклик методу Life() через інтерфейс IPerson

internal interface IPerson
{
    void Life(); // Метод, що визначений в інтерфейсі IPerson
}

internal interface IEmployee : IPerson
{
    void Work(); // Метод, що визначений в інтерфейсі IEmployee, успадковує IPerson
}

class Developer : IEmployee
{
    public void Life()
    {
        Console.WriteLine("Developer life"); // Реалізація методу Life() для класу Developer
    }

    public void Work()
    {
        Console.WriteLine("Developer work"); // Реалізація методу Work() для класу Developer
    }

    public void DrinkCoffe()
    {
        Console.WriteLine("Developer drink coffe"); // Додатковий метод, який не входить до IPerson або IEmployee
    }
}
