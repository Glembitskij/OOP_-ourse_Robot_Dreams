// Створення об'єкта класу Developer за замовчуванням
Developer developer = new Developer();

// Присвоєння значення властивості Age об'єкту developer
developer.Age = 10;

// Зміна значення властивості Age об'єкту developer
developer.Age = 20;

// Абстрактний клас Employee з властивістю salary і абстрактною властивістю Age
internal abstract class Employee
{
    protected int salary; // Захищене поле для зарплати працівника

    public abstract int Age { get; set; } // Абстрактна властивість для віку працівника
}

// Клас Developer, що наслідує клас Employee
internal class Developer : Employee
{
    private int age; // Приватне поле для віку працівника

    // Перевизначення абстрактної властивості Age класу Employee
    public override int Age
    {
        get
        {
            if (age > 0) // Перевірка чи вік більше 0
            {
                return age; // Повернення значення віку
            }
            else
            {
                Console.WriteLine("Value is empty"); // Вивід повідомлення про порожнє значення
                return default; // Повернення значення за замовчуванням (0 для int)
            }
        }
        set
        {
            if (value > 18 && value < 60) // Перевірка чи вік знаходиться в діапазоні 18-60
            {
                age = value; // Присвоєння значення віку
            }
            else
            {
                Console.WriteLine("You entered an invalid value"); // Вивід повідомлення про недійсне значення
            }
        }
    }

    public int Salary // Властивість для зарплати працівника
    {
        get { return salary; } // Повернення значення зарплати
        set { salary = value; } // Присвоєння значення зарплати
    }
}
