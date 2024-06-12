//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Створіть програму, де створіть клас «Трикутник». У тілі класу створіть три
//закриті поля для опису сторін трикутника та три властивості доступу для читання
//та запису. Також у тілі класу створіть 3 методи: 1 - й для розрахунку площі трикутника,
//формула для розрахунку S=√(p*(p-a)*(p-b)*(p-c) ), де p - напівпериметр трикутника,
//формула для розрахунку виглядає наступним чином: p = (a + b + c) / 2,
//де a, b, c – довжини сторін трикутника, 2-й для розрахунку периметра трикутника,
//формула для розрахунку периметру: p = (a + b + c) / 2  і 3-й для виведення інформації
//про площу та периметр трикутника. Створіть конструктор, який як аргументи приймає
//сторони трикутника та ініціалізує поля класу. У методі Main() створіть екземпляр
//класу «Трикутник», задайте довільне значення сторін трикутника та виведіть на екран
//значення периметра та площі трикутника.

// Розв'язок
// Створення екземпляру класу "Трикутник" та ініціалізація сторін
Triangle triangle = new Triangle(3, 4, 5);

// Виведення інформації про площу та периметр трикутника
triangle.DisplayInfo();

internal class Triangle
{
    // Закриті поля для опису сторін трикутника
    private double a;
    private double b;
    private double c;

    // Властивості доступу для читання та запису
    public double A
    {
        get { return a; }
        set { a = value; }
    }

    public double B
    {
        get { return b; }
        set { b = value; }
    }

    public double C
    {
        get { return c; }
        set { c = value; }
    }

    // Конструктор, який приймає сторони трикутника та ініціалізує поля класу
    public Triangle(double sideA, double sideB, double sideC)
    {
        a = sideA;
        b = sideB;
        c = sideC;
    }

    // Метод для розрахунку площі трикутника
    public double CalculateArea()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    // Метод для розрахунку периметра трикутника
    public double CalculatePerimeter()
    {
        return a + b + c;
    }

    // Метод для виведення інформації про площу та периметр трикутника
    public void DisplayInfo()
    {
        double area = CalculateArea();
        double perimeter = CalculatePerimeter();
        Console.WriteLine($"Triangle with sides a = {a}, b = {b}, c = {c}");
        Console.WriteLine($"Perimeter: {perimeter}");
        Console.WriteLine($"Area: {area}");
    }
}