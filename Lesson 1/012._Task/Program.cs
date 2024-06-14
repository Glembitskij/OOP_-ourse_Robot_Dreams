Rectangle rectangle = new Rectangle() { FirstSide = 10, SecondSide = 20 };

//rectangle.FirstSide = 10;
//rectangle.SecondSide = 20;

/*rectangle.FirstSide = 10;
rectangle.SecondSide = 10;*/

// Оголошення прямокутника із заданими сторонами 10 і 20
// Частково закоментовані рядки показують різні способи ініціалізації сторін прямокутника

int square = GetRectangleSquare(rectangle); // Розрахунок площі прямокутника

// Виведення інформації про площу прямокутника
Console.WriteLine(string.Format(@"Площа прямокутника = {0} * {1} = {2}",
    rectangle.FirstSide, rectangle.SecondSide, square));

// Функція для розрахунку площі прямокутника
static int GetRectangleSquare(Rectangle rectangle)
{
    int Square = rectangle.FirstSide * rectangle.SecondSide; // Обчислення площі

    return Square; // Повернення значення площі
}

// Клас, що представляє прямокутник зі сторонами FirstSide і SecondSide
class Rectangle
{
    public int FirstSide { get; set; }   // Перша сторона прямокутника
    public int SecondSide { get; set; }  // Друга сторона прямокутника
}
