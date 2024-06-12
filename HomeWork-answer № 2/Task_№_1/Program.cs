// Створіть програму, в якій створіть базовий клас Animal,
// який має одне поле типу string з ім’ям name та властивість доступу
// до цього поля Name з блоком get; set; та метод MakeSound(),
// який виводить на консоль рядок "Тварина видає звук".
// Потім створіть два дочірні класи: Dog та Cat (базовий клас для них - Animal),
// кожен з яких заміщує метод MakeSound() так, щоб він виводив "Собака гавкає"
// та "Кішка нявкає" відповідно. 

// Розв'язок
// Створення екземплярів класів Dog і Cat
Dog dog = new Dog();
Cat cat = new Cat();

// Присвоєння імен тваринам
dog.Name = "Бобік";
cat.Name = "Мурка";

// Виклик методів MakeSound для кожної тварини
Console.WriteLine($"{dog.Name}:");
dog.MakeSound();

Console.WriteLine($"{cat.Name}:");
cat.MakeSound();

// Базовий клас Animal
internal class Animal
{
    // Поле для імені тварини
    private string? name;

    // Властивість доступу до поля name
    public string? Name
    {
        get { return name; }
        set { name = value; }
    }

    // Метод, який видає звук тварини
    public void MakeSound()
    {
        Console.WriteLine("Тварина видає звук");
    }
}

// Дочірній клас Dog
class Dog : Animal
{
    // Перевизначення методу MakeSound для класу Dog
    public new void MakeSound()
    {
        Console.WriteLine("Собака гавкає");
    }
}

// Дочірній клас Cat
class Cat : Animal
{
    // Перевизначення методу MakeSound для класу Cat
    public new void MakeSound()
    {
        Console.WriteLine("Кішка нявкає");
    }
}