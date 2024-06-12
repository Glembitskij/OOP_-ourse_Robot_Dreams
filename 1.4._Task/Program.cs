
Developer developerAlex = new Developer();
developerAlex.Name = "Alexs";
string? name = developerAlex.Name;

Console.WriteLine(name);

internal class Developer
{
    private string? name;

    public string? Name
    {
        get 
        {
            if (!string.IsNullOrEmpty(name))
            {
                return name;
            }
            else
            {
                return "field doesn't have value^(";
            }
            
        }
        set 
        {
            if (name != "stupid")
            {
                name = value;
            }
            else
            {
                Console.WriteLine("you cannot set such value");
            }
            
        }
    }

    public void WriteCode()
    {
        Console.WriteLine("WriteCode");
    }
}