// Створення об'єкта класу Developer
Developer developer = new Developer();

// Виведення на консоль значення властивості Age
// Оскільки властивість Age ініціалізується значенням за замовчуванням (0 для int), буде виведено 0
Console.WriteLine(developer.Age); // 0

// Базовий клас Employee
internal class Employee
{
    // Публічні властивості для зберігання інформації про працівника
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }

    // Конструктор класу Employee
    public Employee()
    {
        // Ініціалізація властивостей значеннями за замовчуванням
        Name = default;        // null для string
        LastName = default;    // null для string
        Age = default;         // 0 для int
    }
}

// Клас Developer, що наслідує клас Employee
internal class Developer : Employee
{
    // Публічна властивість для зберігання інформації про мову програмування розробника
    public string? ProgramLanguage { get; set; }

    // Конструктор класу Developer
    public Developer()
    {
        // Ініціалізація властивості ProgramLanguage значенням за замовчуванням
        ProgramLanguage = default; // null для string
    }
}