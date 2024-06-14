Developer developer = new Developer();
//developer.Work(); // Коментуємо виклик методу Work() через об'єкт Developer

IPerson person = developer;
person.Work(); // Виклик методу Work() через посилання на IPerson, яке має тип Developer

IEmployee employee = developer;
employee.Work(); // Виклик методу Work() через посилання на IEmployee, яке має тип Developer

internal interface IPerson
{
    void Work(); // Оголошення методу Work() у інтерфейсі IPerson
}

internal interface IEmployee
{
    void Work(); // Оголошення методу Work() у інтерфейсі IEmployee
}

internal class Developer : IPerson, IEmployee
{
    void IPerson.Work()
    {
        Console.WriteLine("IPerson work"); // Явна реалізація методу Work() інтерфейсу IPerson
    }

    void IEmployee.Work()
    {
        Console.WriteLine("IEmployee work"); // Явна реалізація методу Work() інтерфейсу IEmployee
    }
}
