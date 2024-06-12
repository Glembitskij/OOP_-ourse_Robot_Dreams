// Створення єкземпляру класу Developer з ім'ям "Alex"
Developer developerAlex = new Developer();
developerAlex.name = "Alex"; // Встановлення імені
developerAlex.charge = "write code in C#"; // Встановлення завдання
developerAlex.salary = 100; // Встановлення зарплати
developerAlex.WriteCode(); // Виклик методу WriteCode

// Створення іншого єкземпляру класу Developer з ім'ям "Peta"
Developer developerPeta = new Developer();
developerPeta.name = "Peta"; // Встановлення імені
developerPeta.charge = "write code in C++"; // Встановлення завдання
developerPeta.salary = 200; // Встановлення зарплати
developerPeta.WriteCode(); // Виклик методу WriteCode

// Визначення класу Developer
internal class Developer
{
    // Публічні властивості класу
    public string? name; // Ім'я розробника
    public string? charge; // Завдання розробника
    public int? salary; // Зарплата розробника

    // Метод WriteCode, що виконує дію написання коду
    public void WriteCode()
    {
        Console.WriteLine("WriteCode"); // Вивід тексту "WriteCode" на консоль
    }
}