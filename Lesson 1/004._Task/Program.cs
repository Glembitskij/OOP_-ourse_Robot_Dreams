// Створення об'єкту класу Developer
Developer developerAlex = new Developer();

// Встановлення значення властивості Name
developerAlex.Name = "Alexs";

// Отримання значення властивості Name
string? name = developerAlex.Name;

// Виведення отриманого імені на консоль
Console.WriteLine(name); // Виведе "Alexs"

// При спробі встановити заборонене значення
developerAlex.Name = "stupid"; // Виведе "you cannot set such value"

// Клас Developer з властивістю Name для роботи з іменем розробника
internal class Developer
{
    private string? name; // Приватне поле для зберігання імені

    // Властивість Name з публічними методами get і set
    public string? Name
    {
        get
        {
            // Перевірка, чи поле name має значення
            if (!string.IsNullOrEmpty(name))
            {
                return name;
            }
            else
            {
                return "field doesn't have value^(";
            }
        }
        set
        {
            // Перевірка, чи встановлюється допустиме значення
            if (value != "stupid")
            {
                name = value;
            }
            else
            {
                Console.WriteLine("you cannot set such value");
            }
        }
    }

    // Приклад додаткового методу класу Developer
    public void WriteCode()
    {
        Console.WriteLine("WriteCode");
    }
}
