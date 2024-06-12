//Створіть програму, в якій створіть клас «Адрес».У тілі класу створіть
//наступні поля: країна, місто, вулиця, будинок, квартира, індекс.
//Для кожного поля створіть властивість доступу з двома методами доступу
//(get; set;, використовуйте властивості, а не автоматично реалізуємі властивості).
//Також в класі необхідно створити метод для відображення інформації про адресу,
//який буде виводи всю інформацію про адресу на консоль.
//У методі Main() створіть екземпляр класу «Адрес», присвойте всім полям значення
//через властивості доступу (можна використовувати блок ініціалізатора), а також на екземплярі
//класу викличте метод, який виводить інформацію про адресу.

// Розв'язок
// Створення екземпляра класу Address та ініціалізація його властивостей
Address myAddress = new Address()
{
    Country = "Ukraine",
    City = "Kyiv",
    Street = "North",
    House = 15,
    Apartment = 23,
    Index = 14214
};

// Виклик методу для відображення адреси
myAddress.ShowAddress();

internal class Address
{
    // Приватні поля класу Address
    private string? country;     // Країна
    private string? city;        // Місто
    private string? street;      // Вулиця
    private int house;           // Будинок
    private int apartment;       // Квартира
    private int index;           // Поштовий індекс

    // Властивості доступу до приватного поля country
    public string? Country
    {
        get { return country; }
        set { country = value; }
    }

    // Властивості доступу до приватного поля city
    public string? City
    {
        get { return city; }
        set { city = value; }
    }

    // Властивості доступу до приватного поля street
    public string? Street
    {
        get { return street; }
        set { street = value; }
    }

    // Властивості доступу до приватного поля house
    public int House
    {
        get { return house; }
        set { house = value; }
    }

    // Властивості доступу до приватного поля apartment
    public int Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }

    // Властивості доступу до приватного поля index
    public int Index
    {
        get { return index; }
        set { index = value; }
    }

    // Метод для відображення повної адреси
    public void ShowAddress()
    {
        // Виведення адреси у форматі Country-City-Street-House-Apartment-Index
        Console.WriteLine($"{country}-{city}-{street}-{house}-{apartment}-{index}");
    }
}