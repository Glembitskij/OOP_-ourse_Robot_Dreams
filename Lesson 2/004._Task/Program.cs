// Абстракція - це процес приховування деталей реалізації і показ лише
// необхідних характеристик об'єкта. Вона дозволяє спрощувати складність
// шляхом визначення мінімального набору властивостей і методів,
// які необхідні для взаємодії з об'єктом.

Animal[] animals = new Animal[2]; // Створюємо масив об'єктів типу Animal

animals[0] = new Dog("Rex"); // Ініціалізуємо перший елемент масиву як собаку з ім'ям "Rex"
animals[1] = new Cat("Whiskers"); // Ініціалізуємо другий елемент масиву як кота з ім'ям "Whiskers"

foreach (var animal in animals)
{
    animal.MakeSound(); // Викликаємо метод MakeSound для кожного об'єкта типу Animal у масиві
                        // Конкретна реалізація методу MakeSound визначена в кожному класі-нащадку (Dog, Cat)
}


public abstract class Animal
{
    public string Name { get; set; } // Властивість для зберігання ім'я тварини

    public Animal(string name)
    {
        Name = name; // Конструктор для ініціалізації імені тварини
    }

    public abstract void MakeSound(); // Абстрактний метод, що не має реалізації в базовому класі Animal
                                      // Вимагає визначення у всіх класах-нащадках
}

public class Dog : Animal
{
    public Dog(string name) : base(name) // Конструктор класу Dog, що ініціалізує ім'я через базовий конструктор класу Animal
    {
    }

    public override void MakeSound() // Перевизначення методу MakeSound для класу Dog
    {
        Console.WriteLine($"{Name} says Woof!"); // Виведення звуку, який видаватиме собака
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name) // Конструктор класу Cat, що ініціалізує ім'я через базовий конструктор класу Animal
    {
    }

    public override void MakeSound() // Перевизначення методу MakeSound для класу Cat
    {
        Console.WriteLine($"{Name} says Meow!"); // Виведення звуку, який видаватиме кіт
    }
}
