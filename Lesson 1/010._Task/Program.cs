// Варіанти створення об'єктів класу Developer з використанням різних конструкторів

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

// Варіант 4: Конструктор з двома параметрами, який викликає інший конструктор
Developer developerAlex4 = new Developer("Alex", "Shevchenko")
{
    Age = 20
};

// Варіант 5: Конструктор з трьома параметрами
Developer developerAlex5 = new Developer("Alex", "Shevchenko", 20);

// Друк інформації про кожного з розробників
PrintDeveloperInfo(developerAlex1);
PrintDeveloperInfo(developerAlex2);
PrintDeveloperInfo(developerAlex3);
PrintDeveloperInfo(developerAlex4);
PrintDeveloperInfo(developerAlex5);


// Метод для друку інформації про розробника
static void PrintDeveloperInfo(Developer developer)
{
    Console.WriteLine($"Name: {developer.Name}, SecondName: {developer.SecondName}, Age: {developer.Age}");
}


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

    // Конструктор з двома параметрами, який викликає інший конструктор
    public Developer(string name, string secondName) : this(name)
    {
        SecondName = secondName;
    }

    // Конструктор з трьома параметрами
    public Developer(string name, string secondName, int age) : this(name, secondName)
    {
        Age = age;
    }
}
