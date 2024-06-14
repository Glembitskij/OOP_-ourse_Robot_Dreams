Developer developer = new Developer() { PayForHour = 100 };
Manager manager = new Manager() { PayForHour = 50, Bonus = 100 };

int budget = CalculateBudget(developer, manager); // Розрахунок бюджету на оплату праці для розробника і менеджера
Console.WriteLine(budget); // Виведення результату на консоль


// Метод для розрахунку бюджету на оплату праці для декількох співробітників
static int CalculateBudget(params Employee[] employees)
{
    const int hour = 40; // Кількість годин роботи на тиждень
    int result = 0;

    foreach (Employee employee in employees)
    {
        result += employee.CalculateSalary(hour); // Додавання зарплати кожного співробітника до загального бюджету
    }

    return result; // Повернення загального бюджету
}


// Базовий клас Employee з віртуальним методом CalculateSalary
internal class Employee
{
    public int PayForHour { get; set; } // Ставка за годину співробітника

    // Віртуальний метод для розрахунку зарплати співробітника
    public virtual int CalculateSalary(int hour)
    {
        return PayForHour * hour; // Простий розрахунок зарплати на основі ставки за годину і кількості годин
    }
}

// Похідний клас Developer, який успадковує Employee
internal class Developer : Employee
{
    // Немає потреби перевизначати CalculateSalary, оскільки використовується реалізація з базового класу Employee
}

// Похідний клас Manager, який успадковує Employee і перевизначає метод CalculateSalary
internal class Manager : Employee
{
    public int Bonus { get; set; } // Бонус для менеджера

    // Перевизначений метод для розрахунку зарплати менеджера з урахуванням бонусу
    public override int CalculateSalary(int hour)
    {
        return base.CalculateSalary(hour) + Bonus; // Додавання бонусу до зарплати, обчисленої в базовому класі Employee
    }
}
