Rectangle rectangle = GetRectangle(10, 20);

Console.WriteLine("Площадь прямоугольника {0}", rectangle.Square); // Виведення площі прямокутника
Console.WriteLine("Периметр прямоугольника {0}", rectangle.Perimeter); // Виведення периметру прямокутника

// Функція для створення прямокутника із заданими сторонами та обчислення площі і периметру
static Rectangle GetRectangle(int a, int b)
{
    Rectangle rectangle = new Rectangle(); // Створення нового об'єкту Rectangle

    rectangle.Square = a * b; // Обчислення площі прямокутника
    rectangle.Perimeter = 2 * (a + b); // Обчислення периметру прямокутника

    return rectangle; // Повернення об'єкту Rectangle з обчисленими значеннями площі і периметру
}

// Клас, що представляє прямокутник із властивостями Square (площа) і Perimeter (периметр)
class Rectangle
{
    public decimal Square { get; set; } // Властивість для площі прямокутника
    public decimal Perimeter { get; set; } // Властивість для периметру прямокутника
}
