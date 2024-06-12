
//Developer developerAlex = new Developer();
//developerAlex.Name = "Alex";
//developerAlex.SecondName = "Shevchenko";
//developerAlex.Age = 20;

//Developer developerAlex = new Developer()
//{
//    Name = "Alex",
//    SecondName = "Shevchenko",
//    Age = 20
//};

//Developer developerAlex = new Developer("Alex")
//{
//    SecondName = "Shevchenko",
//    Age = 20
//};

//Developer developerAlex = new Developer("Alex", "Shevchenko")
//{
//    Age = 20
//};

Developer developerAlex = new Developer("Alex", "Shevchenko", 20);

internal class Developer
{
    public string? Name { get; set; }

    public string? SecondName { get; set; }

    public int Age { get; set; }

    public Developer()
    {
    }

    public Developer(string name)
    {
        Name = name;
    }

    public Developer(string name, string secondName): this(name)
    {
        SecondName = secondName;
    }

    public Developer(string name, string secondName, int age): this(name, secondName)
    {
        Age = age;
    }
}