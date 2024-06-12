// Створіть програму в якій опишіть ієрархію класів для співробітників компанії.
//Перш за все створіть базовий клас Employee з наступними полями:
//ім'я співробітника (string Name), вік співробітника (int Age) та посада
//співробітника (string Position), створіть властивості доступу до кожного із описаних полів.
//Також в класі  Employee створіть метод Work(), який нічого не повертає та виводить
//інформацію про роботу співробітника. Після чого створіть дочірній клас Manager,
//який наслідуєтся від Employee, та має додаткове поле кількість підлеглих
//(int NumberOfSubordinates) і метод Work() який має додатково виводити інформацію
//про управління підлеглими. Також створіть дочірній клас Developer, який наслідуєтся від Employee,
//з додатковими полем мова програмування (ProgrammingLanguage) і методом Work(), який
//має виводити інформацію про розробку на конкретній мові програмування.
//Після чого у методі Main створіть кілька об'єктів класів Manager і Developer,
//заповніть їх поля і викличте метод Work() для кожного об'єкта.

// Розв'язок
// Створення об'єктів класів Manager і Developer
Manager manager = new Manager
{
    Name = "John",
    Age = 35,
    Position = "Manager",
    NumberOfSubordinates = 10
};

Developer developer = new Developer
{
    Name = "Alice",
    Age = 28,
    Position = "Developer",
    ProgrammingLanguage = "C#"
};

// Виклик методу Work() для кожного об'єкта
manager.Work();
developer.Work();

// Базовий клас Employee
internal class Employee
{
    // Поля базового класу
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Position { get; set; }

    // Метод роботи співробітника
    public void Work()
    {
        Console.WriteLine($"Employee {Name}, position {Position} is working.");
    }
}

// Дочірній клас Manager
internal class Manager : Employee
{
    // Додаткове поле для кількості підлеглих
    public int NumberOfSubordinates { get; set; }

    // Перевизначений метод роботи для менеджера
    public new void Work()
    {
        base.Work();
        Console.WriteLine($"Managing {NumberOfSubordinates} subordinates.");
    }
}

// Дочірній клас Developer
internal class Developer : Employee
{
    // Додаткове поле для мови програмування
    public string? ProgrammingLanguage { get; set; }

    // Перевизначений метод роботи для розробника
    public new void Work()
    {
        base.Work();
        Console.WriteLine($"Developing in {ProgrammingLanguage}.");
    }
}
