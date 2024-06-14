MathOperation math = new MathOperation();

// Виклик методів Sum з різними параметрами і виведення результатів на консоль
Console.WriteLine(math.Sum(10, 20));          // Викликає метод Sum(int a, int b)
Console.WriteLine(math.Sum(10.0, 12.1));      // Викликає метод Sum(double a, double b)
Console.WriteLine(math.Sum(1, 1, 1));         // Викликає метод Sum(float a, float b, float c)
Console.WriteLine(math.Sum(new int[] { 10, 20, 30 })); // Викликає метод Sum(int[] array)


// Клас MathOperation з перевантаженими методами Sum
internal class MathOperation
{
    // Метод для сумування двох цілих чисел
    public int Sum(int a, int b)
    {
        return a + b;
    }

    // Метод для сумування двох дійсних чисел
    public double Sum(double a, double b)
    {
        return a + b;
    }

    // Метод для сумування трьох чисел з плаваючою точкою (float)
    public float Sum(float a, float b, float c)
    {
        return a + b + c;
    }

    // Метод для сумування масиву цілих чисел
    public int Sum(int[] array)
    {
        int sum = 0;

        foreach (int num in array)
        {
            sum += num;
        }

        return sum;
    }
}
