// Створення об'єктів класів Developer та Manager з використанням ініціалізаторів об'єктів
Developer developer = new Developer()
{
    Name = "Alex",
    Age = 30,
    ProgramLanguage = "C#"
};

Manager manager = new Manager()
{
    Name = "Vasa",
    Age = 20,
    Category = "program"
};

// Приведення (upcasting) об'єктів до базового типу Employee
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

        // Перевірка, чи є поточний працівник типу Developer (downcasting)
        if (employee is Developer)
        {
            Developer developer = (Developer)employee; // Downcasting
            Console.WriteLine(developer.ProgramLanguage); // Виведення мови програмування для розробника
        }
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
