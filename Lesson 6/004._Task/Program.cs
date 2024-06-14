// Створення об'єкта класу Developer за замовчуванням
Developer developer1 = new Developer();

// Створення об'єкта класу Developer з переданим параметром name
Developer developer2 = new Developer("Alex");

// Створення об'єкта класу Developer з переданими параметрами name та age
Developer developer3 = new Developer("Alex", 30);

// Створення об'єкта класу Developer з переданими параметрами name, age та programLanguage
Developer developer4 = new Developer("Alex", 30, "C#");

// Абстрактний клас Employee
internal abstract class Employee
{
    // Властивість для імені працівника
    public string? Name { get; set; }

    // Властивість для віку працівника
    public int Age { get; set; }

    // Конструктор класу Employee за замовчуванням
    public Employee()
    {
        Name = default; // Ім'я за замовчуванням (null)
        Age = default;  // Вік за замовчуванням (0)
    }

    // Захищений конструктор класу Employee з параметром name
    protected Employee(string name)
    {
        Name = name;
    }

    // Захищений конструктор класу Employee з параметрами name та age
    protected Employee(string name, int age) : this(name)
    {
        Age = age;
    }
}

// Клас Developer, що наслідує клас Employee
internal class Developer : Employee
{
    // Властивість для мови програмування
    public string? ProgramLanguage { get; set; }

    // Конструктор класу Developer за замовчуванням
    public Developer()
    {
        ProgramLanguage = default; // Мова програмування за замовчуванням (null)
    }

    // Конструктор класу Developer з параметром name
    public Developer(string name) : base(name)
    {
    }

    // Конструктор класу Developer з параметрами name та age
    public Developer(string name, int age) : base(name, age)
    {
    }

    // Конструктор класу Developer з параметрами name, age та programLanguage
    public Developer(string name, int age, string programLanguage) : base(name, age)
    {
        ProgramLanguage = programLanguage;
    }
}
