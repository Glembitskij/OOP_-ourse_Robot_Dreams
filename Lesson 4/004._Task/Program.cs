Employee employee1 = new Employee();
Employee employee2 = new Employee("Vasa");
Employee employee3 = new Employee("Vasa", "Shevchenko");
Employee employee4 = new Employee("Vasa", "Shevchenko", 20);

Developer developer1 = new Developer("Peta");
Developer developer2 = new Developer("Peta", "Petrov");
Developer developer3 = new Developer("Peta", "Petrov", 30);
Developer developer4 = new Developer("Peta", "Petrov", 30, "C#");

internal class Employee
{
    public string? Name { get; set; }

    public string? LastName { get; set; }

    public int Age { get; set; }

    public Employee() {
            
    }
    
    public Employee(string name) {
        Name = name;
    }

    public Employee(string name, string lastName):this(name) {
        LastName = lastName;
    }

    public Employee(string name, string lastName, int age):this(name, lastName) {
        Age = age;
    }
}


internal class Developer : Employee
{
    public string? ProgramLanguage { get; set; }

    public Developer() {
        
    }

    public Developer(string name): base(name) {
        
    }

    public Developer(string name, string lastName) : base(name, lastName) {

    }

    public Developer(string name, string lastName, int age) : base(name, lastName, age) {

    }

    public Developer(string name, string lastName, int age, string programLanguage) : base(name, lastName, age) {
        ProgramLanguage = programLanguage;
    }
}