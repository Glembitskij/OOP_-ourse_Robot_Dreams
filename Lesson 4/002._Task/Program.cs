// Створення об'єкта класу Employee
Employee employee = new Employee();
// Встановлення імені працівника
employee.Name = "Alex";
// Поля LastName та Salary недоступні ззовні класу Employee
// employee.LastName; // Недоступно
// employee.Salary; // Недоступно

// Створення об'єкта класу Developer
Developer developer = new Developer();
// Встановлення імені розробника
developer.Name = "Vasa";
// Поля LastName та Salary недоступні ззовні класу Developer, оскільки вони успадковані з Employee
// developer.LastName; // Недоступно
// developer.Salary; // Недоступно

// Виклик методу для відображення базової інформації розробника
developer.ShowBaseInfo();

// Зміна базової інформації розробника
developer.ChengeBaseInfo();
Console.WriteLine(new string('-', 20));

// Повторний виклик методу для відображення зміненої базової інформації розробника
developer.ShowBaseInfo();

// Базовий клас Employee
internal class Employee
{
    // Публічне поле для зберігання імені працівника
    public string? Name;

    // Захищене поле для зберігання прізвища працівника (доступне в похідних класах)
    protected string? LastName = "Shevchenko";

    // Приватне поле для зберігання зарплати працівника (доступне тільки всередині класу)
    private int Salary;
}

// Клас Developer, що наслідує клас Employee
internal class Developer : Employee
{
    // Метод для відображення базової інформації розробника
    public void ShowBaseInfo()
    {
        Console.WriteLine(Name); // Доступ до публічного поля Name
        Console.WriteLine(LastName); // Доступ до захищеного поля LastName
        // Console.WriteLine(Salary); // Недоступно, оскільки Salary є приватним полем в Employee
    }

    // Метод для зміни базової інформації розробника
    public void ChengeBaseInfo()
    {
        Name = "Peta"; // Зміна публічного поля Name
        LastName = "Ivanov"; // Зміна захищеного поля LastName
        // Salary = 100; // Недоступно, оскільки Salary є приватним полем в Employee
    }
}