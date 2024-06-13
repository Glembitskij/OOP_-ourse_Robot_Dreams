Developer developer = new Developer()
{
    PayForHour = 200,
    Bonus = 100
};

int salary = developer.CalculateSalary(40);
Console.WriteLine(salary);

internal class Employee
{
    public int PayForHour { get; set; }

    public virtual int CalculateSalary(int hour)
    {
        return PayForHour * hour;
    }
}

internal class Developer : Employee
{
    public int Bonus { get; set; }

    public override int CalculateSalary(int hour)
    {
        return base.CalculateSalary(hour) + Bonus;
    }
}

