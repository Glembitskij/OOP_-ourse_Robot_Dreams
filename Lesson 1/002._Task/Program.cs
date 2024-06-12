
Developer developerAlex = new Developer();

developerAlex.SetName("Alexs");
string? name = developerAlex.GetName();

Console.WriteLine(name);

internal class Developer
{
    private string? name;

    public string? GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        name = value;
    }

    public void WriteCode()
    {
        Console.WriteLine("WriteCode");
    }
}