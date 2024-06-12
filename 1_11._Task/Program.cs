Developer developerAlex = new Developer();

GC.Collect();

internal class Developer
{
    public string? Name { get; set; }

    public string? SecondName { get; set; }

    public int Age { get; set; }

    public Developer()
    {
        Console.WriteLine("Constructor work");
    }

    ~Developer()
    {
        Console.WriteLine("Destructor work");
    }
}