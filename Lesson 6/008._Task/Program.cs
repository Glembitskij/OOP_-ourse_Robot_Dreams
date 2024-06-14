Developer developer = new Developer();
developer.Life(); // Виклик методу Life() класу Developer
developer.Work(); // Виклик методу Work() класу Developer
developer.DrinkCoffe(); // Виклик методу DrinkCoffe() класу Developer

IEmployee employee = developer;
employee.Work(); // Виклик методу Work(), оскільки developer є також IEmployee

IPerson person = developer;
developer.DrinkCoffe(); // Виклик методу DrinkCoffe(), оскільки developer є також IPerson

Object obj = developer; // developer зберігається як Object

internal interface IPerson
{
    void Life(); // Метод, що визначений в інтерфейсі IPerson
}

internal interface IEmployee
{
    void Work(); // Метод, що визначений в інтерфейсі IEmployee
}

class Developer : Object, IPerson, IEmployee
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
