Developer developer = new Developer();
developer.Age = 10;
developer.Age = 20;
internal abstract class Employee
{
    protected int salary;
    public abstract int Age { get; set; }
}

internal class Developer : Employee
{
    private int age;
    public override int Age
    {
        get 
        {
            if (age > 0)
            {
                return age;
            }
            else
            {
                Console.WriteLine("Value is empty");
                return default;
            }
        }
        set 
        {
            if (value > 18 && value < 60)
            {
                age = value;
            }
            else 
            {
                Console.WriteLine("You entered an invalid value");
            }
        }
    }

    public int Salary
    {
        get { return salary; }
        set { salary = value; }
    }
}