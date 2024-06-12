Rectangle rectangle = GetRectangle(10, 20);

Console.WriteLine("Площадь прямоугольника {0}", rectangle.Square);
Console.WriteLine("Периметр прямоугольника {0}", rectangle.Perimeter);

static Rectangle GetRectangle(int a, int b)
{
    Rectangle rectangle = new Rectangle();

    rectangle.Square = a * b;
    rectangle.Perimeter = 2 * (a + b);

    return rectangle;
}

class Rectangle
{
    public decimal Square { get; set; }

    public decimal Perimeter { get; set; }
}