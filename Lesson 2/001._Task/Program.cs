﻿// 1. Інкапсуляція поєднує дані та код, що маніпулює цими даними,
// а також захищає і те, й інше від зовнішнього втручання або неправильного використання.
// Разом вони створюють об'єкт, у якому можуть бути приватні дані,
// якими можуть маніпулювати лише методи об'єкта.

// Створює новий об'єкт класу Developer
Developer dev = new Developer();

// Встановлює ім'я розробника
dev.Name = "Alice";

// Виводить ім'я розробника
Console.WriteLine(dev.Name);

// Викликає метод ShowRandomValue для відображення випадкового числа
dev.ShowRandomValue();

internal class Developer
{
    // Приватне поле для зберігання імені розробника
    private string? name;

    // Публічна властивість для доступу до імені розробника
    public string? Name
    {
        get
        {
            // Повертає значення поля name
            return name;
        }
        set
        {
            // Встановлює значення поля name
            name = value;
        }
    }

    // Приватний метод для обчислення випадкового числа
    private int CalculateRandom()
    {
        // Генерує випадкове число від 0 до 99 і повертає його
        return new Random().Next(0, 100);
    }

    // Публічний метод для відображення випадкового числа
    public void ShowRandomValue()
    {
        // Викликає метод CalculateRandom і виводить результат на консоль
        Console.WriteLine(CalculateRandom());
    }
}