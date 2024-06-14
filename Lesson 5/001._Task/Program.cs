Employee employee = new Employee();
employee.GetInfo(); // Виклик методу GetInfo з класу Employee

Developer developer = new Developer();
developer.GetInfo(); // Виклик методу GetInfo з класу Developer (перевизначений метод)

Employee employeeDev = developer;
employeeDev.GetInfo(); // Поліморфізм: виклик методу GetInfo з класу Developer через змінну типу Employee

Developer developerAgain = (Developer)employeeDev;
developerAgain.GetInfo(); // Виклик методу GetInfo з класу Developer після розпакування змінної типу Employee


// Базовий клас Employee з методом GetInfo
internal class Employee
{
    public void GetInfo()
    {
        Console.WriteLine("Employee");
    }
}

// Похідний клас Developer, який успадковує Employee і перевизначає метод GetInfo
internal class Developer : Employee
{
    public new void GetInfo()
    {
        Console.WriteLine("Developer");
    }
}
