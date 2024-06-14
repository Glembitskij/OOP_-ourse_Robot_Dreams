// Створення об'єктів класу Employee з різними конструкторами
Employee employee1 = new Employee(); // Виклик конструктора за замовчуванням
Employee employee2 = new Employee("Vasa"); // Виклик конструктора з одним параметром
Employee employee3 = new Employee("Vasa", "Shevchenko"); // Виклик конструктора з двома параметрами
Employee employee4 = new Employee("Vasa", "Shevchenko", 20); // Виклик конструктора з трьома параметрами

// Створення об'єктів класу Developer з різними конструкторами
Developer developer1 = new Developer("Peta"); // Виклик конструктора з одним параметром
Developer developer2 = new Developer("Peta", "Petrov"); // Виклик конструктора з двома параметрами
Developer developer3 = new Developer("Peta", "Petrov", 30); // Виклик конструктора з трьома параметрами
Developer developer4 = new Developer("Peta", "Petrov", 30, "C#"); // Виклик конструктора з чотирма параметрами

// Базовий клас Employee
internal class Employee
{
    // Публічні властивості для зберігання інформації про працівника
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }

    // Конструктор за замовчуванням
    public Employee()
    {
    }

    // Конструктор з одним параметром (ім'я)
    public Employee(string name)
    {
        Name = name;
    }

    // Конструктор з двома параметрами (ім'я, прізвище)
    public Employee(string name, string lastName) : this(name)
    {
        LastName = lastName;
    }

    // Конструктор з трьома параметрами (ім'я, прізвище, вік)
    public Employee(string name, string lastName, int age) : this(name, lastName)
    {
        Age = age;
    }
}

// Клас Developer, що наслідує клас Employee
internal class Developer : Employee
{
    // Публічна властивість для зберігання інформації про мову програмування розробника
    public string? ProgramLanguage { get; set; }

    // Конструктор за замовчуванням
    public Developer()
    {
    }

    // Конструктор з одним параметром (ім'я)
    public Developer(string name) : base(name)
    {
    }

    // Конструктор з двома параметрами (ім'я, прізвище)
    public Developer(string name, string lastName) : base(name, lastName)
    {
    }

    // Конструктор з трьома параметрами (ім'я, прізвище, вік)
    public Developer(string name, string lastName, int age) : base(name, lastName, age)
    {
    }

    // Конструктор з чотирма параметрами (ім'я, прізвище, вік, мова програмування)
    public Developer(string name, string lastName, int age, string programLanguage) : base(name, lastName, age)
    {
        ProgramLanguage = programLanguage;
    }
}