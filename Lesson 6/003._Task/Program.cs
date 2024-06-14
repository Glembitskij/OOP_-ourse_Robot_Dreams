// Створення об'єкта класу Developer
Developer developer = new Developer();

// Виведення віку розробника. На даний момент значення буде за замовчуванням (0)
Console.WriteLine(developer.Age); // ?

// Абстрактний клас Employee
internal abstract class Employee
{
    // Властивість для імені працівника
    public string? Name { get; set; }

    // Властивість для віку працівника
    public int Age { get; set; }

    // Конструктор класу Employee, що встановлює значення за замовчуванням
    public Employee()
    {
        Name = default; // Ім'я за замовчуванням (null)
        Age = default;  // Вік за замовчуванням (0)
    }
}

// Клас Developer, що наслідує клас Employee
internal class Developer : Employee
{
    // Властивість для мови програмування
    public int ProgramLanguage { get; set; }

    // Конструктор класу Developer, що встановлює значення за замовчуванням
    public Developer()
    {
        ProgramLanguage = default; // Мова програмування за замовчуванням (0)
    }
}
