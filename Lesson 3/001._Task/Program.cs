Employee employee = new Employee(); // Створення нового об'єкта класу Employee
employee.Name = "Alex"; // Присвоєння значення властивості Name
employee.Age = 30; // Присвоєння значення властивості Age

// employee.age = 20 // Неможливо присвоїти значення age напряму, оскільки це приватне поле

internal class Employee
{
    // Публічне поле для зберігання імені
    public string? Name;

    // Приватне поле для зберігання віку
    private int age;

    // Властивість для доступу до віку з можливістю отримання та встановлення значення
    public int Age
    {
        get { return age; } // Гетер для отримання значення віку
        set { age = value; } // Сетер для встановлення значення віку
    }
}
