// 1. Інкапсуляція поєднує дані та код, що маніпулює цими даними,
// а також захищає і те, й інше від зовнішнього втручання або неправильного використання.
// Разом вони створюють об'єкт, у якому можуть бути приватні дані,
// якими можуть маніпулювати лише методи об'єкта.

Console.WriteLine(1);
internal class Developer
{
    private string? name;

    public string? Name
    {
        get 
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    private int CalculateRandom()
    {
        return new Random().Next(0, 100);
    }

    public void ShowRandomValue()
    {
        Console.WriteLine(CalculateRandom());
    }
}