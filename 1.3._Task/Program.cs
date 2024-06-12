
Developer developerAlex = new Developer();
developerAlex.Name = "Alexs";
string? name = developerAlex.Name;

Console.WriteLine(name);

internal class Developer
{
    private string? name;

    public string? Name 
    { 
        get // public string? GetName()
        { 
            return name; 
        }
        set // SetName(string value)
        { 
            name = value; 
        } 
    }

    public void WriteCode()
    {
        Console.WriteLine("WriteCode");
    }
}