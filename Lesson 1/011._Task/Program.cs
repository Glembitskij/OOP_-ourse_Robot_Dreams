// Створення нового об'єкта класу Developer
Developer developerAlex = new Developer();

// Виклик збірника сміття для явного очищення пам'яті
GC.Collect();

// Визначення класу Developer, який містить дані про розробника
internal class Developer
{
    public string? Name { get; set; }       // Ім'я розробника
    public string? SecondName { get; set; }  // Прізвище розробника
    public int Age { get; set; }            // Вік розробника

    // Конструктор, який викликається при створенні нового об'єкта Developer
    public Developer()
    {
        Console.WriteLine("Constructor work");  // Виводить повідомлення про виклик конструктора
    }

    // Деструктор, який викликається перед знищенням об'єкта Developer
    ~Developer()
    {
        Console.WriteLine("Destructor work");   // Виводить повідомлення про виклик деструктора
    }
}
