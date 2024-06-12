// Створіть програму, в якій створіть базовий клас Shape (фігура),
// який містить поле типу double з ім'ям Volume і метод типу double GetVolume()
// який повинен повернути об’єм фігури. Далі створіть класи: Pyramid (піраміда),
// Cylinder (циліндр), Ball (куля), які унаслідуються від класу Shape,
// реалізуйте в кожному з них метод для знаходження об'єму. Створіть клас
// Box (ящик) – фактично він є контейнером та може містити інші фігури.
// У класі Box створіть поле типу double з ім'ям DrawerVolume (обєм ящика),
// поле має зберігати об'єм скриньки. Далі у класі Box створіть метод Аdd(),
// який приймає на вхід об'єкти типу Shape, та повертає значення типу boll.
// У класі Box реалізуйте логіку для додавання нових фігур до тих пір, поки для них
// вистачає місця в Box (вважатимемо тільки об'єм, ігноруючи форму, наприклад,
// ми переливаємо рідину). Якщо місця для додавання нової фігури не вистачає,
// метод повинен повернути false.

// Розв'язок
// Створення об'єкту ящика з об'ємом 1000
Box box = new Box(1000);

// Додавання різних фігур у ящик
Pyramid pyramid = new Pyramid(100, 20);
Cylinder cylinder = new Cylinder(5, 10);
Ball ball = new Ball(7);

// Додавання фігур до ящика з перевіркою
bool success1 = box.Add(pyramid);
bool success2 = box.Add(cylinder);
bool success3 = box.Add(ball);

// Виведення результатів додавання
Console.WriteLine($"Adding pyramid: {success1}");
Console.WriteLine($"Adding cylinder: {success2}");
Console.WriteLine($"Adding ball: {success3}");

// Базовий клас Shape (фігура)
internal abstract class Shape
{
    public double Volume { get; protected set; } // Об'єм фігури

    // Абстрактний метод для знаходження об'єму фігури
    public abstract double GetVolume();
}

// Клас Pyramid (піраміда), успадковується від Shape
internal class Pyramid : Shape
{
    private double baseArea; // Площа основи
    private double height;   // Висота піраміди

    // Конструктор для піраміди
    public Pyramid(double baseArea, double height)
    {
        this.baseArea = baseArea;
        this.height = height;
        Volume = GetVolume();
    }

    // Перевизначений метод для знаходження об'єму піраміди
    public override double GetVolume()
    {
        return (1.0 / 3.0) * baseArea * height;
    }
}

// Клас Cylinder (циліндр), успадковується від Shape
internal class Cylinder : Shape
{
    private double radius; // Радіус основи циліндра
    private double height; // Висота циліндра

    // Конструктор для циліндра
    public Cylinder(double radius, double height)
    {
        this.radius = radius;
        this.height = height;
        Volume = GetVolume();
    }

    // Перевизначений метод для знаходження об'єму циліндра
    public override double GetVolume()
    {
        return Math.PI * radius * radius * height;
    }
}

// Клас Ball (куля), успадковується від Shape
internal class Ball : Shape
{
    private double radius; // Радіус кулі

    // Конструктор для кулі
    public Ball(double radius)
    {
        this.radius = radius;
        Volume = GetVolume();
    }

    // Перевизначений метод для знаходження об'єму кулі
    public override double GetVolume()
    {
        return (4.0 / 3.0) * Math.PI * radius * radius * radius;
    }
}

// Клас Box (ящик)
internal class Box
{
    private double DrawerVolume; // Об'єм ящика
    private double UsedVolume;   // Використаний об'єм ящика
    private List<Shape> shapes;  // Список фігур у ящику

    // Конструктор для ящика
    public Box(double drawerVolume)
    {
        DrawerVolume = drawerVolume;
        UsedVolume = 0;
        shapes = new List<Shape>();
    }

    // Метод для додавання фігури у ящик
    public bool Add(Shape shape)
    {
        double shapeVolume = shape.GetVolume();
        if (UsedVolume + shapeVolume <= DrawerVolume)
        {
            shapes.Add(shape);
            UsedVolume += shapeVolume;
            return true;
        }
        else
        {
            return false;
        }
    }
}
