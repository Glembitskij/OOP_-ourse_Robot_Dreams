Point a = new Point("A", 1, 1);
Point b = new Point("B", 1, 1);

Console.WriteLine(a.ToString()); 
Console.WriteLine(b.ToString()); 

Console.WriteLine(a.Equals((object)b)); 

Console.WriteLine(a.GetHashCode()); 
Console.WriteLine(b.GetHashCode());

internal class Point : object
{
    public string? Name { get; set; }
    public int X { get; set; }

    public int Y { get; set; }

    public Point(string name, int x, int y)
    {
        Name = name;
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"Point {Name} with coordinates: x - {X}, y - {Y}";
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Point point))
        {
            return false;
        }

        return point.X == X && point.Y == Y;
    }

    public override int GetHashCode()
    {
        return X * Y;
    }
}