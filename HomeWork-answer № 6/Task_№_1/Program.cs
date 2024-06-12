// Створіть інтерфейс IMovable, який містить метод Move(). Потім створіть два класи:
// Car і Person, які реалізують цей інтерфейс. Клас Car повинен мати поле для
// швидкості і реалізувати метод Move() для виведення повідомлення про те, що
// автомобіль рухається зі швидкістю. Клас Person повинен мати поле для ім’я та
// реалізувати метод Move() для виведення повідомлення про те, що людина йде.
// Створіть екземпляри цих класів і продемонструйте їх  приклади використання методів,
// також зробіть upcast до базового інтерфейсного типу.

// Розв'язок
// Створення екземпляру класу Car
Car car = new Car { Speed = 60 };
car.Move(); // Виклик методу Move() для автомобіля

// Створення екземпляру класу Person
Person person = new Person { Name = "John" };
person.Move(); // Виклик методу Move() для людини

// Upcast до інтерфейсного типу IMovable
IMovable movable1 = car;
IMovable movable2 = person;

// Використання інтерфейсного посилання для виклику методу Move()
movable1.Move();
movable2.Move();

// Інтерфейс IMovable з методом Move()
internal interface IMovable
{
    void Move();
}

// Клас Car, що реалізує інтерфейс IMovable
internal class Car : IMovable
{
    public int Speed { get; set; } // Швидкість автомобіля

    public void Move()
    {
        Console.WriteLine($"Car is moving at speed of {Speed} km/h");
    }
}

// Клас Person, що реалізує інтерфейс IMovable
internal class Person : IMovable
{
    public string? Name { get; set; } // Ім'я людини

    public void Move()
    {
        Console.WriteLine($"Person {Name} is walking");
    }
}