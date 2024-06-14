// Створення об'єкту класу Developer з використанням різних конструкторів

// Варіант 1: Встановлення властивостей по одній
Developer developerAlex1 = new Developer();
developerAlex1.Name = "Alex";
developerAlex1.SecondName = "Shevchenko";
developerAlex1.Age = 20;

// Варіант 2: Використання ініціалізатора об'єктів (object initializer)
Developer developerAlex2 = new Developer()
{
    Name = "Alex",
    SecondName = "Shevchenko",
    Age = 20
};

// Варіант 3: Конструктор з одним параметром
Developer developerAlex3 = new Developer("Alex")
{
    SecondName = "Shevchenko",
    Age = 20
};

// Варіант 4: Конструктор з двома параметрами
Developer developerAlex4 = new Developer("Alex", "Shevchenko")
{
    Age = 20
};

// Варіант 5: Конструктор з трьома параметрами
Developer developerAlex5 = new Developer("Alex", "Shevchenko", 20);

// Клас Developer з різними конструкторами для ініціалізації властивостей
internal class Developer
{
    public string? Name { get; set; } // Публічна властивість Name з можливістю читання і запису

    public string? SecondName { get; set; } // Публічна властивість SecondName з можливістю читання і запису

    public int Age { get; set; } // Публічна властивість Age з можливістю читання і запису, типу int

    // Конструктор без параметрів (дефолтний конструктор)
    public Developer()
    {
    }

    // Конструктор з одним параметром
    public Developer(string name)
    {
        Name = name;
    }

    // Конструктор з двома параметрами
    public Developer(string name, string secondName)
    {
        Name = name;
        SecondName = secondName;
    }

    // Конструктор з трьома параметрами
    public Developer(string name, string secondName, int age)
    {
        Name = name;
        SecondName = secondName;
        Age = age;
    }
}
