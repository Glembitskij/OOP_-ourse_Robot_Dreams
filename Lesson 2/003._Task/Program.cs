// Поліморфізм - це здатність об'єктів різних класів виконувати
// однакові дії (тобто виклик одного й того ж методу чи властивості) і
// мати різну реалізацію цих дій, залежно від типу об'єкта, до якого
// вони належать.

// Створення об'єктів різних класів
Shape[] shapes = new Shape[3];
shapes[0] = new Rectangle { Width = 5, Height = 10 };
shapes[1] = new Circle { Radius = 7 };
shapes[2] = new Rectangle { Width = 3, Height = 4 };

// Виведення площі кожної фігури, використовуючи поліморфізм
foreach (var shape in shapes)
{
    Console.WriteLine($"Площа фігури: {shape.Area()}");
}

// Батьківський клас Shape
class Shape
{
    // Віртуальний метод для обчислення площі
    public virtual double Area()
    {
        return 0;
    }
}

// Похідний клас Rectangle, що успадковує клас Shape
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    // Перевизначення методу Area з батьківського класу
    public override double Area()
    {
        return Width * Height;
    }
}

// Похідний клас Circle, що успадковує клас Shape
class Circle : Shape
{
    public double Radius { get; set; }

    // Перевизначення методу Area з батьківського класу
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
