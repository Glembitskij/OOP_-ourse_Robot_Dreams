
Employee employee = new Employee();
employee.Name = "Alex";
employee.Age = 30;

// employee.age = 20

internal class Employee
{
    public string? Name;

    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

}
