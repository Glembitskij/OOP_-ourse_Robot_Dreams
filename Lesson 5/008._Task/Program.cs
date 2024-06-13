Point point = new Point(0, 0);

Console.WriteLine("a   = {0}", point);
Console.WriteLine("a++ = {0}", point++);
Console.WriteLine("a   = {0}", point);

Console.WriteLine("a-- = {0}", point--);
Console.WriteLine("a   = {0}", point);

Console.WriteLine("++a = {0}", ++point);
Console.WriteLine("a   = {0}", point);

Console.WriteLine("--a = {0}", --point);
Console.WriteLine("a   = {0}", point);

Point point1 = new Point(1, 3);
Point point2 = new Point(2, 4);

point1 += point2;

Console.WriteLine(point1);

public class Point
{
    public int X { get; set; }

    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y);
    }

    public static Point operator *(Point p1, Point p2)
    {
        return new Point(p1.X * p2.X, p1.Y * p2.Y);
    }

    public static Point operator /(Point p1, Point p2)
    {
        return new Point(p1.X / p2.X, p1.Y / p2.Y);
    }

    public override string ToString()
    {
        return string.Format("[{0}, {1}]", this.X, this.Y);
    }

    public static bool operator >(Point p1, Point p2)
    {
        return p1.Equals(p2);
    }

    public static bool operator <(Point p1, Point p2)
    {
        return !p1.Equals(p2);
    }

    public static Point operator ++(Point p1)
    {
        return new Point(p1.X + 1, p1.Y + 1);
    }

    public static Point operator --(Point p1)
    {
        return new Point(p1.X - 1, p1.Y - 1);
    }
}