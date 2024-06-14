// Створення об'єкту класу Developer
Developer developerAlex = new Developer();

// Отримання значення властивості Name (яке зараз є null)
string? name = developerAlex.Name;

// Виведення отриманого імені на консоль
Console.WriteLine(name); // Виведе null, оскільки значення не було встановлено


// Клас Developer з властивістю Name для роботи з іменем розробника
internal class Developer
{
    private string? name; // Приватне поле для зберігання імені

    // Властивість Name з методом get для отримання значення поля name
    public string? Name
    {
        get
        {
            return name;
        }
    }

    // Приклад додаткового методу класу Developer
    public void WriteCode()
    {
        Console.WriteLine("WriteCode");
    }
}
