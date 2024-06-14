// Створення об'єкта pointA типу Point з використанням конструктора
Point pointA = new Point(1, 2);

// Упакування (Boxing): конвертація значимого типу Point в посилання типу Object
Object obj = pointA;

// Розпакування (Unboxing): конвертація об'єкта типу Object назад до значимого типу Point
Point againPoint = (Point)obj;

// Виведення координат точки, щоб показати, що розпакування відбулося правильно
Console.WriteLine($"Coordinates of againPoint: X = {againPoint.X}, Y = {againPoint.Y}");


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
