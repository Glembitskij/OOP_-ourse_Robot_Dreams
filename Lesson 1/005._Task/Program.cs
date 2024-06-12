
Developer developerAlex = new Developer();
//developerAlex.Name = "Alexs";
string? name = developerAlex.Name;

Console.WriteLine(name);

internal class Developer
{
    private string? name;

    public string? Name
    {
        get
        {
            return name;
        }
    }

    public void WriteCode()
    {
        Console.WriteLine("WriteCode");
    }
}