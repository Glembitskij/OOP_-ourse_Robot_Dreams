Employee employee = new Employee();
int salary1 = employee.CalculateSalary(); // Викликає метод CalculateSalary() класу Employee
Console.WriteLine($"Employee salary: {salary1}");

Developer developer = new Developer();
int salary2 = developer.CalculateSalary(); // Викликає перевизначений метод CalculateSalary() класу Developer
Console.WriteLine($"Developer salary: {salary2}");

Employee employeeDev = developer;
int salary3 = employeeDev.CalculateSalary(); // Викликає перевизначений метод CalculateSalary() класу Developer через посилання базового класу Employee
Console.WriteLine($"Employee as Developer salary: {salary3}");

// При спробі створення класу NetDeveloper, що успадковує sealed метод CalculateSalary з класу Developer, код не компілюватиметься.
// NetDeveloper netDeveloper = new NetDeveloper();


// Базовий клас Employee з віртуальним методом CalculateSalary
class Employee
{
    public virtual int CalculateSalary()
    {
        // Повертає випадкове ціле число в діапазоні від 1 до 10
        return new Random().Next(1, 10);
    }
}

// Похідний клас Developer, який успадковує Employee
class Developer : Employee
{
    // Перевизначений метод CalculateSalary з використанням ключового слова sealed
    public sealed override int CalculateSalary()
    {
        // Розраховує зарплату розробника, подвоюючи зарплату, отриману з базового класу
        return base.CalculateSalary() * 2;
    }
}

// Приклад спроби створення класу NetDeveloper, який успадковує sealed метод CalculateSalary з класу Developer
//class NetDeveloper : Developer
//{
// При розкоментуванні перевизначення методу код не буде компілюватися, оскільки метод CalculateSalary у Developer позначений як sealed.
//public override int CalculateSalary()
//{
//return base.CalculateSalary();
//}
//}
