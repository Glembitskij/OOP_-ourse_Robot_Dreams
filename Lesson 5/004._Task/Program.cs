Point a = new Point("A", 1, 1);
Point b = new Point("B", 1, 1);

Console.WriteLine(a.ToString()); // Виводить інформацію про точку a
Console.WriteLine(b.ToString()); // Виводить інформацію про точку b

Console.WriteLine(a.Equals((object)b)); // Порівнює точки a і b за допомогою методу Equals

Console.WriteLine(a.GetHashCode()); // Виводить хеш-код точки a
Console.WriteLine(b.GetHashCode()); // Виводить хеш-код точки b

// Клас Point, який успадковує клас object
internal class Point : object
{
    public string? Name { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    // Конструктор для ініціалізації властивостей точки
    public Point(string name, int x, int y)
    {
        Name = name;
        X = x;
        Y = y;
    }

    // Перевизначений метод ToString для отримання рядкового представлення точки
    public override string ToString()
    {
        return $"Point {Name} with coordinates: x - {X}, y - {Y}";
    }

    // Перевизначений метод Equals для порівняння двох точок за координатами
    public override bool Equals(object? obj)
    {
        if (!(obj is Point point))
        {
            return false;
        }

        return point.X == X && point.Y == Y;
    }

    // Перевизначений метод GetHashCode для отримання хеш-коду точки
    public override int GetHashCode()
    {
        return X * Y;
    }
}
