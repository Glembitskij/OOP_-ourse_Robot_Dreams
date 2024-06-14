// Створення об'єкта класу Developer з ініціалізацією властивостей
Developer developer = new Developer()
{
    Name = "Alex",
    Age = 30,
    ProgramLanguage = "C#"
};

// Створення об'єкта класу Manager з ініціалізацією властивостей
Manager manager = new Manager()
{
    Name = "Vasa",
    Age = 20,
    Category = "program"
};

// Перетворення об'єктів developer і manager до типу Employee
Employee employeeDev = (Employee)developer;
Employee employeeMan = (Employee)manager;

// Виклик методу для відображення інформації про всіх працівників
AllEmployeeIntroduce(employeeDev, employeeMan);


// Метод для відображення інформації про всіх працівників
static void AllEmployeeIntroduce(params Employee[] employees)
{
    foreach (Employee employee in employees)
    {
        // Виклик методу Introduce для кожного працівника
        employee.Introduce();
    }
}


// Базовий клас Employee
internal class Employee
{
    // Публічні властивості для зберігання інформації про працівника
    public string? Name { get; set; }
    public int Age { get; set; }

    // Метод для відображення інформації про працівника
    public void Introduce()
    {
        Console.WriteLine($"{Name} - {Age}");
    }
}

// Клас Developer, що наслідує клас Employee
internal class Developer : Employee
{
    // Публічна властивість для зберігання інформації про мову програмування розробника
    public string? ProgramLanguage { get; set; }
}

// Клас Manager, що наслідує клас Employee
internal class Manager : Employee
{
    // Публічна властивість для зберігання інформації про категорію менеджера
    public string? Category { get; set; }
}