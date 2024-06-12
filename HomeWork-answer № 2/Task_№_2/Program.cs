//Створіть програму, в якій створіть клас «Банківський Рахунок».
//У тілі класу створіть такі поля: дата відкриття рахунку, процентна ставка
//за рахунком, сума рахунку. У тілі класу створіть такі методи: 
//1.метод, який розраховує кількість днів, починаючи з дати відкриття
//рахунку, метод має повертати цілочисельний тип даних;
//2.метод, який виводить інформацію про кількість розрахованих днів,
//метод має нічого не повертати, та використовувати функціонал попереднього
//методу для отримання інформації;
//3.метод, який розраховує суму, яка буде на рахунку через певну кількість
//років (кількість років – параметр методу);
//4.метод, який виводить інформацію про суму. Також продумати над
//конструкторами класу (які поля мають бути 100 відсотків проініціалізованими).
//У методі Main() створіть екземпляр класу «Банківський Рахунок», надайте всім
//полям значення через властивості доступу (можна використати конструктор
//класу або блок ініціалізатора), а також на екземпляр класу викличте методи
//для відображення кількості днів та суми.

// Розв'язок
// Створення екземпляра класу "Банківський Рахунок"
BankAccount myAccount = new BankAccount(new DateTime(2020, 1, 1), 5.0, 10000.0);

// Виклик методів для відображення кількості днів та суми
myAccount.PrintDaysSinceOpening();
myAccount.PrintFutureBalance(5);

// Клас "Банківський Рахунок"
internal class BankAccount
{
    // Поля класу
    private DateTime openingDate;
    private double interestRate;
    private double balance;

    // Властивості доступу до полів
    public DateTime OpeningDate
    {
        get { return openingDate; }
        set { openingDate = value; }
    }

    public double InterestRate
    {
        get { return interestRate; }
        set { interestRate = value; }
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    // Конструктор класу
    public BankAccount(DateTime openingDate, double interestRate, double balance)
    {
        this.openingDate = openingDate;
        this.interestRate = interestRate;
        this.balance = balance;
    }

    // Метод для розрахунку кількості днів з дати відкриття рахунку
    public int GetDaysSinceOpening()
    {
        return (DateTime.Now - openingDate).Days;
    }

    // Метод для виведення інформації про кількість днів з дати відкриття рахунку
    public void PrintDaysSinceOpening()
    {
        int days = GetDaysSinceOpening();
        Console.WriteLine($"Кількість днів з дати відкриття рахунку: {days}");
    }

    // Метод для розрахунку суми на рахунку через певну кількість років
    public double CalculateFutureBalance(int years)
    {
        return balance * Math.Pow((1 + interestRate / 100), years);
    }

    // Метод для виведення інформації про майбутню суму на рахунку
    public void PrintFutureBalance(int years)
    {
        double futureBalance = CalculateFutureBalance(years);
        Console.WriteLine($"Сума на рахунку через {years} років: {futureBalance:F2}");
    }
}