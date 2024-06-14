// Створення об'єкту класу Developer
Developer developerAlex = new Developer();

// Встановлення значення імені через властивість Name
developerAlex.Name = "Alexs";

// Виклик методу для виведення імені на консоль
developerAlex.WriteName(); // Виведе "Alexs"

// Клас Developer з властивістю Name для роботи з іменем розробника
internal class Developer
{
    private string? name; // Приватне поле для зберігання імені

    // Властивість Name з методом set для встановлення значення поля name
    public string? Name
    {
        set
        {
            name = value;
        }
    }

    // Метод для виведення імені на консоль
    public void WriteName()
    {
        Console.WriteLine(name);
    }

    // Приклад додаткового методу класу Developer
    public void WriteCode()
    {
        Console.WriteLine("WriteCode");
    }
}
