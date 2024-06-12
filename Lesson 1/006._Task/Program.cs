
Developer developerAlex = new Developer();
developerAlex.Name = "Alexs";
//string? name = developerAlex.Name;

internal class Developer
{
    private string? name;

    public string? Name
    {
        set
        {
            name = value;
        }
    }

    public void WriteName()
    {
        Console.WriteLine(name);
    }

    public void WriteCode()
    {
        Console.WriteLine("WriteCode");
    }
}