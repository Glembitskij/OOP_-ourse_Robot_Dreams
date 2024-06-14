Developer developer = new Developer();
developer.Work(); // Виклик методу Work() класу Developer
developer.Life(); // Виклик методу Life() класу Developer

Employee employee = developer;
employee.Work(); // Виклик методу Work() через інтерфейс Employee, успадкований від Developer
employee.Life(); // Виклик методу Life() через інтерфейс Employee, успадкований від Developer

IPerson person = developer;
person.Life(); // Виклик методу Life() через інтерфейс IPerson, успадкований від Developer

public interface IPerson
{
    void Life(); // Сигнатура методу, що оголошена в інтерфейсі IPerson
}

abstract class Employee : IPerson
{
    public abstract void Work(); // Абстрактний метод Work, що потрібно реалізувати у нащадках

    public abstract void Life(); // Абстрактний метод Life, що потрібно реалізувати у нащадках
}

class Developer : Employee
{
    public override void Life()
    {
        Console.WriteLine("Developer life"); // Реалізація методу Life() для класу Developer
    }

    public override void Work()
    {
        Console.WriteLine("Developer Work"); // Реалізація методу Work() для класу Developer
    }
}
