Car car = new Car();
Ford ford = new Ford();

// Встановлення значення властивості Name для об'єкта типу Car
car.Name = "Generic Car";

// Встановлення значення властивості Name для об'єкта типу Ford, що успадкований від Car
ford.Name = "Ford Car";

// Виведення значень властивостей Name для об'єктів car і ford
Console.WriteLine($"Car name: {car.Name}");
Console.WriteLine($"Ford name: {ford.Name}");


// Базовий клас Car з властивістю Name
class Car
{
    public string? Name { get; set; }
}

// Запечатаний клас Ford, який успадковує клас Car
sealed class Ford : Car
{
    // Додаткових членів або перевизначення відсутнє, оскільки клас запечатаний
}

// Приклади класів, які не можуть успадковуватись через запечатаність класу
//class Mondeo : Ford
//{

//}

//class MyString : String
//{

//}
