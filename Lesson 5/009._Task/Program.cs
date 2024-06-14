// Створення об'єкту класу Person з параметризованим типом string
Person<string> person1 = new Person<string>();

// Створення об'єкту класу Person з параметризованим типом int
Person<int> person2 = new Person<int>();

// Налаштування значення для властивості PersonNumber обох об'єктів
person1.PersonNumber = "12345";
person2.PersonNumber = 67890;

// Виведення значень властивостей обох об'єктів на консоль
Console.WriteLine("Person 1: " + person1.PersonNumber);
Console.WriteLine("Person 2: " + person2.PersonNumber);


// Клас Person з параметризованим типом T
class Person<T>
{
    // Властивість PersonNumber з параметризованим типом T
    public T? PersonNumber { get; set; }
}
