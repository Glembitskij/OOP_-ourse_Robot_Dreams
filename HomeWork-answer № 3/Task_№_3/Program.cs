// Створіть програму в якій опишіть клас Employee. Цей клас має містити три приватні
// поля для імені (name), прізвища (surname) та заробітної плати (salary).
// Реалізуйте публічні властивості доступу для отримання та зміни значень цих полів.
// Переконайтеся, що зарплата не може бути негативною а прізвище та ім’я не можуть
// бути довшими за 10 та 20 символів відповідно.

// Розв'язок

Employee employee = new Employee("Андрій", "Іванов", 5000m);

// Виклик методу для виведення інформації про працівника
employee.DisplayInfo();

// Спроба встановити некоректні значення
employee.Name = "ДужеДужеДовгеІмя";
employee.Surname = "ДужеДовгеПрізвище";
employee.Salary = -1000m;

// Клас "Співробітник"
class Employee
{
    // Приватні поля
    private string? name;
    private string? surname;
    private decimal salary;

    // Публічна властивість для імені
    public string? Name
    {
        get { return name; }
        set
        {
            if (value?.Length > 20)
                Console.WriteLine("Ім'я не може бути довшим за 20 символів.");
            name = value;
        }
    }

    // Публічна властивість для прізвища
    public string? Surname
    {
        get { return surname; }
        set
        {
            if (value?.Length > 10)
                Console.WriteLine("Прізвище не може бути довшим за 10 символів.");
            surname = value;
        }
    }

    // Публічна властивість для заробітної плати
    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < 0)
                Console.WriteLine("Заробітна плата не може бути негативною.");
            salary = value;
        }
    }

    // Конструктор класу
    public Employee(string name, string surname, decimal salary)
    {
        Name = name;
        Surname = surname;
        Salary = salary;
    }

    // Метод для виведення інформації про працівника
    public void DisplayInfo()
    {
        Console.WriteLine($"Ім'я: {Name}, Прізвище: {Surname}, Зарплата: {Salary}");
    }
}
