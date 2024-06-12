// Створіть програму, в якій створіть клас BankAccount. В тілі даного класу
// створіть три приватні поля, а саме поле для номера рахунку (accountNumber),
// балансу (balance) та імені власника (ownerName), всі три поля мають бути приватними.
// Після чого реалізуйте публічні властивості для отримання та зміни значень цих полів.
// Переконайтеся, що баланс не може бути негативним та імя власника має
// починатись тільки з великої літери.

// Розв'язок
// Створення екземпляра класу "Банківський Рахунок"
BankAccount myAccount = new BankAccount("UA1234567890", 5000.0, "Alex");

// Виведення інформації про рахунок
myAccount.PrintAccountInfo();

// Спроба встановити негативний баланс
myAccount.Balance = -100.0;

// Спроба встановити ім'я власника з малої літери
myAccount.OwnerName = "alex";

// Коректне оновлення балансу та імені власника
myAccount.Balance = 3000.0;
myAccount.OwnerName = "Alexandra";

// Виведення оновленої інформації про рахунок
myAccount.PrintAccountInfo();

// Клас "Банківський Рахунок"
class BankAccount
{
    // Приватні поля
    private string? accountNumber;
    private double balance;
    private string? ownerName;

    // Властивість для доступу до accountNumber
    public string? AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    // Властивість для доступу до balance з перевіркою, що баланс не може бути негативним
    public double Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("Баланс не може бути негативним.");
            }
        }
    }

    // Властивість для доступу до ownerName з перевіркою, що ім'я власника починається з великої літери
    public string? OwnerName
    {
        get { return ownerName; }
        set
        {
            if (!string.IsNullOrEmpty(value) && char.IsUpper(value[0]))
            {
                ownerName = value;
            }
            else
            {
                Console.WriteLine("Ім'я власника має починатися з великої літери.");
            }
        }
    }

    // Конструктор класу
    public BankAccount(string accountNumber, double balance, string ownerName)
    {
        AccountNumber = accountNumber;
        Balance = balance;
        OwnerName = ownerName;
    }

    // Метод для виведення інформації про рахунок
    public void PrintAccountInfo()
    {
        Console.WriteLine($"Номер рахунку: {AccountNumber}");
        Console.WriteLine($"Баланс: {Balance}");
        Console.WriteLine($"Ім'я власника: {OwnerName}");
    }
}

