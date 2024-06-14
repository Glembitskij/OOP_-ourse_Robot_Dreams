Developer developer = new Developer();
developer.DrinkCoffe(); // Виклик методу DrinkCoffe() у об'єкті developer
developer.DoWork(); // Виклик методу DoWork() у об'єкті developer
developer.Life(); // Виклик методу Life() у об'єкті developer

Employee employee = developer; // Приведення типу Developer до типу Employee
employee.DoWork(); // Виклик методу DoWork() через посилання на Employee
developer.Life(); // Виклик методу Life() через посилання на Employee (реалізація з Developer)

Person person = developer; // Приведення типу Developer до типу Person
person.Life(); // Виклик методу Life() через посилання на Person

internal class Person
{
    public void Life()
    {
        Console.WriteLine("Person life"); // Вивід повідомлення про "життя" особи
    }
}

internal abstract class Employee : Person
{
    public abstract void DoWork(); // Абстрактний метод DoWork(), який мають реалізувати похідні класи
}

internal class Developer : Employee
{
    public override void DoWork()
    {
        Console.WriteLine("Developer write code"); // Реалізація методу DoWork() для класу Developer
    }

    public void DrinkCoffe()
    {
        Console.WriteLine("Developer drink coffee"); // Метод, що додає функціональність Developer
    }
}
