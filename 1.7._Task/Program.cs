Developer developerAlex = new Developer();
developerAlex.Name = "Alexs";

Console.WriteLine(developerAlex.Name);

internal class Developer
{
    public string? Name { get; set; }

    public string? SecondName { get; } = "Alex";

    public int Age { private get;  set; }
}