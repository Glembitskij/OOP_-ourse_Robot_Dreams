// Наслідування(inheritance) — це один з основних принципів об'єктно-орієнтованого
// програмування (ООП), який дозволяє одному класу успадковувати властивості та
// методи іншого класу. Завдяки наслідуванню можна створювати нові класи на
// основі вже існуючих, що сприяє повторному використанню коду, зменшує його
// дублювання та спрощує підтримку програмного забезпечення.

// Створення об'єкта класу Dog
Dog myDog = new Dog
{
    Name = "Buddy",
    Age = 3,
    Breed = "Golden Retriever"
};

// Виклик методів класу Dog
myDog.Describe();

// Створення об'єкта класу Cat
Cat myCat = new Cat
{
    Name = "Whiskers",
    Age = 2,
    Color = "Gray"
};

// Виклик методів класу Cat
myCat.Describe();

// Базовий клас (батьківський клас)
internal class Animal
{
    // Властивості базового класу
    public string? Name { get; set; }
    public int Age { get; set; }

    // Метод базового класу
    public void Describe()
    {
        Console.WriteLine($"I am an animal named {Name} and I am {Age} years old.");
    }
}

// Похідний клас (дочірній клас), який наслідує базовий клас Animal
internal class Dog : Animal
{
    // Додаткові властивості похідного класу
    public string? Breed { get; set; }
}

// Похідний клас (дочірній клас), який наслідує базовий клас Animal
internal class Cat : Animal
{
    // Додаткові властивості похідного класу
    public string? Color { get; set; }
}