// Створення об'єкту класу Developer
Developer developerAlex = new Developer();

// Зчитування значення властивості Age (значення за замовчуванням, 0)
int age = developerAlex.Age;

// Виведення значення на консоль
Console.WriteLine(age); // Виведе "0", оскільки значення Age не було встановлено


// Клас Developer з властивістями Name, SecondName і Age
internal class Developer
{
    public string? Name { get; set; } // Публічна властивість Name з можливістю читання і запису

    public string? SecondName { get; set; } // Публічна властивість SecondName з можливістю читання і запису

    public int Age { get; set; } // Публічна властивість Age з можливістю читання і запису, типу int

    //public Developer()
    //{
    //    Name = default;
    //    SecondName = default;
    //    Age = default;
    //}
}