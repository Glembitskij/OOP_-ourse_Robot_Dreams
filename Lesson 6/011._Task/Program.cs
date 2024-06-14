Developer developer = new Developer();
developer.Work(); // Виклик методу Work() класу Developer
developer.Life(); // Виклик методу Life() успадкованого від Employee, перевизначений в Developer

Employee employee = developer;
employee.Work(); // Виклик методу Work() через посилання на Employee, яке має тип Developer
employee.Life(); // Виклик методу Life() через посилання на Employee, яке має тип Developer

IPerson person = developer;
person.Life(); // Виклик методу Life() через посилання на IPerson, яке має тип Developer

public interface IPerson
{
    void Life(); // Оголошення методу Life() у інтерфейсі IPerson
}

abstract class Employee : IPerson
{
    public abstract void Work(); // Абстрактний метод Work() у класі Employee

    public void Life()
    {
        Console.WriteLine("Employee life"); // Реалізація методу Life() у класі Employee
    }
}

class Developer : Employee
{
    public override void Work()
    {
        Console.WriteLine("Developer Work"); // Реалізація методу Work() у класі Developer
    }
}
