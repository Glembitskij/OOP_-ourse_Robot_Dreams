// Створення об'єкту класу Developer
Developer developerAlex = new Developer();

// Встановлення значення імені через властивість Name
developerAlex.Name = "Alexs";

// Виведення імені на консоль
Console.WriteLine(developerAlex.Name); // Виведе "Alexs"

// Клас Developer з різними властивостями
internal class Developer
{
    public string? Name { get; set; } // Публічна властивість Name з можливістю читання і запису

    public string? SecondName { get; } = "Alex"; // Публічна властивість SecondName з можливістю читання, встановлення тільки в конструкторі

    public int Age { private get; set; } // Приватна властивість Age з можливістю запису в класі, дефолтний (default) конструктор
}
