Employee employee = new Employee();
employee.CalculateSalary();

Developer developer = new Developer();
developer.CalculateSalary();

Employee employeeDev = developer;
employeeDev.CalculateSalary();

class Employee
{
    public virtual int CalculateSalary()
    {
        return new Random().Next(1, 10);
    }
}

class Developer : Employee
{
    public sealed override int CalculateSalary()
    {
        return base.CalculateSalary() * 2;
    }
}

class NetDeveloper: Developer
{
    //public override int CalculateSalary()
    //{
        //return base.CalculateSalary();
    //}
}