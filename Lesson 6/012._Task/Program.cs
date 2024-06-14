Developer developer = new Developer();
developer.Work(); // Виклик методу Work() через об'єкт класу Developer

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
    public void Work()
    {
        Console.WriteLine("Developer work"); // Реалізація методу Work() у класі Developer
    }
}
