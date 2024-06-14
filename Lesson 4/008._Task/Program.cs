// Створення об'єкта pointA типу Point з використанням конструктора
Point pointA = new Point(1, 2);

// Виведення координат точки pointA
Console.WriteLine($"Coordinates of pointA: X = {pointA.X}, Y = {pointA.Y}");


// Структура Point для зберігання координат точки
struct Point
{
    // Властивість X для зберігання координати X
    public int X { get; set; }

    // Властивість Y для зберігання координати Y
    public int Y { get; set; }

    // Конструктор для ініціалізації координат X та Y
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}
