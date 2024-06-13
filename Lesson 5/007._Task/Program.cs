
MathOperation math = new MathOperation();

Console.WriteLine(math.Sum(10, 20));
Console.WriteLine(math.Sum(10.0, 12.1));
Console.WriteLine(math.Sum(1,1,1));
Console.WriteLine(math.Sum(new int[] {10,20,30}));

internal class MathOperation
{
    public int Sum(int a, int b)
    {
        return a + b; 
    }

    public double Sum(double a, double b)
    {
        return a + b; 
    }

    public float Sum(float a, float b, float c)
    {
        return a + b + c; 
    }

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
