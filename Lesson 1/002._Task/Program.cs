// Створення об'єкту класу Developer
Developer developerAlex = new Developer();

// Встановлення ім'я через метод SetName
developerAlex.SetName("Alexs");

// Отримання ім'я через метод GetName
string? name = developerAlex.GetName();

// Виведення отриманого імені на консоль
Console.WriteLine(name); // Виведе "Alexs"


// Клас Developer з приватним полем name і публічними методами для роботи з ним
internal class Developer
{
    private string? name; // Приватне поле для зберігання імені

    // Метод для отримання імені
    public string? GetName()
    {
        return name;
    }

    // Метод для встановлення імені
    public void SetName(string value)
    {
        name = value;
    }

    // Приклад додаткового методу класу Developer
    public void WriteCode()
    {
        Console.WriteLine("WriteCode");
    }
}