Rectangle rectangle = new Rectangle() { FirstSide = 10, SecondSide = 20 };

//rectangle.FirstSide = 10;
//rectangle.SecondSide = 20;

/*rectangle.FirstSide = 10;
rectangle.SecondSide = 10;*/


int square = GetRectangleSquare(rectangle);

Console.WriteLine(string.Format(@"Площа прямокутника = {0} * {1} = {2}",
    rectangle.FirstSide, rectangle.SecondSide, square));

static int GetRectangleSquare(Rectangle rectangle)
{
    int Square = rectangle.FirstSide * rectangle.SecondSide;

    return Square;
}

class Rectangle
{
    public int FirstSide { get; set; }

    public int SecondSide { get; set; }
}