// Створення об'єкта класу Manager та виклик його методів
Manager manager = new Manager();
manager.DoWork(); // Виклик методу DoWork класу Manager
manager.DrinkCoffe(); // Виклик методу DrinkCoffe, успадкованого від класу Employee
int managerSalary = manager.GetSalary(); // Отримання зарплати менеджера
Console.WriteLine(managerSalary); // Виведення зарплати менеджера

// Створення об'єкта класу Developer та виклик його методів
Developer developer = new Developer();
developer.DoWork(); // Виклик методу DoWork класу Developer
developer.DrinkCoffe(); // Виклик методу DrinkCoffe, успадкованого від класу Employee
int developerSalary = developer.GetSalary(); // Отримання зарплати розробника
Console.WriteLine(developerSalary); // Виведення зарплати розробника

// Абстрактний клас Employee
internal abstract class Employee
{
    // Абстрактний метод DoWork, який повинен бути реалізований у похідних класах
    public abstract void DoWork();

    // Віртуальний метод GetSalary, який можна перевизначити у похідних класах
    public virtual int GetSalary()
    {
        return new Random().Next(1, 10); // Генерація випадкової зарплати від 1 до 10
    }

    // Метод DrinkCoffe, реалізований у базовому класі
    public void DrinkCoffe()
    {
        Console.WriteLine("Employee drink coffe");
    }
}

// Клас Developer, який наслідує клас Employee
internal class Developer : Employee
{
    // Реалізація методу DoWork для класу Developer
    public override void DoWork()
    {
        Console.WriteLine("Developer write code");
    }

    // Перевизначення методу GetSalary для класу Developer
    public override int GetSalary()
    {
        return base.GetSalary() + 100; // Базова зарплата + 100
    }
}

// Клас Manager, який наслідує клас Employee
internal class Manager : Employee
{
    // Реалізація методу DoWork для класу Manager
    public override void DoWork()
    {
        Console.WriteLine("Manager do work");
    }
}
