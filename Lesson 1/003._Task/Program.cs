// Створення об'єкту класу Developer
Developer developerAlex = new Developer();

// Встановлення значення властивості Name
developerAlex.Name = "Alexs";

// Отримання значення властивості Name
string? name = developerAlex.Name;

// Виведення отриманого імені на консоль
Console.WriteLine(name); // Виведе "Alexs"


// Клас Developer з властивістю Name для роботи з іменем розробника
internal class Developer
{
    private string? name; // Приватне поле для зберігання імені

    // Властивість Name з публічними методами get і set
    public string? Name
    {
        //  public string? GetName()
        get // Метод для отримання значення імені
        {
            return name;
        }
        //public void SetName(string value)
        set // Метод для встановлення значення імені
        {
            name = value;
        }
    }

    // Приклад додаткового методу класу Developer
    public void WriteCode()
    {
        Console.WriteLine("WriteCode");
    }
}
