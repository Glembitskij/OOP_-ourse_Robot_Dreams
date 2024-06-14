
Developer developer1 = new Developer();

Developer developer2 = new Developer("Alex");

Developer developer3 = new Developer("Alex", 30);

Developer developer4 = new Developer("Alex", 30, "C#");

internal abstract class Employee
{
    public string? Name { get; set; }

    public int Age { get; set; }

    public Employee() {
        Name = default;
        Age = default;
    }

    protected Employee(string name) {
        Name = name;
    }

    protected Employee(string name, int age): this(name) {
        Age = age;
    }
}

internal class Developer : Employee
{
    public string? ProgramLanguage { get; set; }

    public Developer() {
        ProgramLanguage = default;
    }

    public Developer(string name): base(name) {
            
    }

    public Developer(string name, int age) : base(name, age) {

    }

    public Developer(string name, int age, string programLanguage) : base(name, age) {
        ProgramLanguage = programLanguage;
    }
}