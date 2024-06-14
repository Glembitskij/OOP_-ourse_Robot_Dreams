Developer developer = new Developer()
{
    PayForHour = 200, // Встановлення ставки за годину для розробника
    Bonus = 100 // Встановлення бонусу для розробника
};

int salary = developer.CalculateSalary(40); // Розрахунок заробітної плати за 40 годин
Console.WriteLine(salary); // Виведення заробітної плати на консоль


// Базовий клас Employee з віртуальним методом CalculateSalary
internal class Employee
{
    public int PayForHour { get; set; } // Ставка за годину

    // Віртуальний метод для розрахунку заробітної плати
    public virtual int CalculateSalary(int hour)
    {
        return PayForHour * hour; // Розрахунок заробітної плати за годину
    }
}

// Похідний клас Developer, який успадковує Employee і перевизначає метод CalculateSalary
internal class Developer : Employee
{
    public int Bonus { get; set; } // Бонус для розробника

    // Перевизначений метод для розрахунку заробітної плати розробника з урахуванням бонусу
    public override int CalculateSalary(int hour)
    {
        // Виклик базового методу для розрахунку зарплати за годину і додавання бонусу
        return base.CalculateSalary(hour) + Bonus;
    }
}
