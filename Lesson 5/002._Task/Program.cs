Employee employee = new Employee();
employee.GetInfo(); // Виклик віртуального методу GetInfo з класу Employee

Developer developer = new Developer();
developer.GetInfo(); // Виклик перевизначеного методу GetInfo з класу Developer

Employee employeeDev = developer;
employeeDev.GetInfo(); // Поліморфізм: виклик перевизначеного методу GetInfo з класу Developer через змінну типу Employee

Developer developerAgain = (Developer)employeeDev;
developerAgain.GetInfo(); // Виклик перевизначеного методу GetInfo з класу Developer після розпакування змінної типу Employee


// Базовий клас Employee з віртуальним методом GetInfo
internal class Employee
{
    public virtual void GetInfo()
    {
        Console.WriteLine("Employee");
    }
}

// Похідний клас Developer, який успадковує Employee і перевизначає віртуальний метод GetInfo
internal class Developer : Employee
{
    public override void GetInfo()
    {
        Console.WriteLine("Developer");
    }
}
