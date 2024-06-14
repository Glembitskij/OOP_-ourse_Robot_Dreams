Point point = new Point(0, 0);

Console.WriteLine("a   = {0}", point);        // Виводить поточні значення точки
Console.WriteLine("a++ = {0}", point++);     // Постфіксний інкремент
Console.WriteLine("a   = {0}", point);        // Виводить збільшене значення точки

Console.WriteLine("a-- = {0}", point--);     // Постфіксний декремент
Console.WriteLine("a   = {0}", point);        // Виводить зменшене значення точки

Console.WriteLine("++a = {0}", ++point);     // Префіксний інкремент
Console.WriteLine("a   = {0}", point);        // Виводить збільшене значення точки

Console.WriteLine("--a = {0}", --point);     // Префіксний декремент
Console.WriteLine("a   = {0}", point);        // Виводить зменшене значення точки

Point point1 = new Point(1, 3);
Point point2 = new Point(2, 4);

point1 += point2;   // Використання перевантаженого оператора додавання

Console.WriteLine(point1);  // Виводить результат додавання точок

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Перевантаження оператора додавання
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    // Перевантаження оператора віднімання
    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y);
    }

    // Перевантаження оператора множення
    public static Point operator *(Point p1, Point p2)
    {
        return new Point(p1.X * p2.X, p1.Y * p2.Y);
    }

    // Перевантаження оператора ділення
    public static Point operator /(Point p1, Point p2)
    {
        return new Point(p1.X / p2.X, p1.Y / p2.Y);
    }

    // Перевантаження оператора ++ (постфіксний інкремент)
    public static Point operator ++(Point p1)
    {
        return new Point(p1.X + 1, p1.Y + 1);
    }

    // Перевантаження оператора -- (постфіксний декремент)
    public static Point operator --(Point p1)
    {
        return new Point(p1.X - 1, p1.Y - 1);
    }

    // Перевантаження методу ToString для виводу координат точки
    public override string ToString()
    {
        return string.Format("[{0}, {1}]", this.X, this.Y);
    }
}
