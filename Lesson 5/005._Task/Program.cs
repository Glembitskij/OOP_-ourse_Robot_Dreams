Developer developer = new Developer() { PayForHour = 100 };
Manager manager = new Manager() {PayForHour = 50, Bonus = 100 };

int budget = CalculateBudget(developer, manager);

Console.WriteLine(budget);

static int CalculateBudget(params Employee[] employees)
{
    const int hour = 40;
    int result = 0;

    foreach (Employee employee in employees)
    {
        result += employee.CalculateSalary(hour);
    }

    return result;
}

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
}

internal class Manager : Employee
{
    public int Bonus { get; set; }
    
    public override int CalculateSalary(int hour)
    {
        return base.CalculateSalary(hour) + Bonus;
    }
}
