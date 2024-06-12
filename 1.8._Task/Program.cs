Developer developerAlex = new Developer();
int age = developerAlex.Age;

Console.WriteLine(age);

int variable;
//Console.WriteLine(variable);

internal class Developer
{
    public string? Name { get; set; }

    public string? SecondName { get; set; }

    public int Age {  get; set; }

    //public Developer()
    //{
    //    Name = default;
    //    SecondName = default;
    //    Age = default;
    //}
}