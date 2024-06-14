//Employee employee = new Employee(); // Не можна створити екземпляр абстрактного класу Employee

// Створення об'єктів класів Manager та Developer
Manager manager = new Manager();
Developer developer = new Developer();

// Виклик методу StartWork з масивом об'єктів типу Employee
StartWork(manager, developer);

// Метод StartWork приймає змінну кількість параметрів типу Employee
static void StartWork(params Employee[] employees)
{
    // Проходимо через кожен об'єкт Employee у масиві employees
    foreach (Employee employee in employees)
    {
        // Виклик методу DoWork для кожного об'єкта Employee
        employee.DoWork();

        // Перевірка, чи є об'єкт типу Developer
        if (employee is Developer)
        {
            // Приведення об'єкта Employee до типу Developer
            Developer developer = (Developer)employee;
            // Виклик методу DrinkCoffe для об'єкта Developer
            developer.DrinkCoffe();
        }
    }
}

// Абстрактний клас Employee з абстрактним методом DoWork
internal abstract class Employee
{
    public abstract void DoWork(); // Абстрактний метод, який повинен бути реалізований у похідних класах
}

// Клас Developer, що наслідує клас Employee
internal class Developer : Employee
{
    // Реалізація абстрактного методу DoWork для класу Developer
    public override void DoWork()
    {
        Console.WriteLine("Developer write code");
    }

    // Метод DrinkCoffe для класу Developer
    public void DrinkCoffe()
    {
        Console.WriteLine("Developer drink coffe");
    }
}

// Клас Manager, що наслідує клас Employee
internal class Manager : Employee
{
    // Реалізація абстрактного методу DoWork для класу Manager
    public override void DoWork()
    {
        Console.WriteLine("Manager do work");
    }
}
