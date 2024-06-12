//Створіть програму, в якій створіть клас «Адрес».У тілі класу створіть
//наступні поля: країна, місто, вулиця, будинок, квартира, індекс.
//Для кожного поля створіть властивість доступу з двома методами доступу
//(get; set;, використовуйте властивості, а не автоматично реалізуємі властивості).
//Також в класі необхідно створити метод для відображення інформації про адресу,
//який буде виводи всю інформацію про адресу на консоль.
//У методі Main() створіть екземпляр класу «Адрес», присвойте всім полям значення
//через властивості доступу (можна використовувати блок ініціалізатора), а також на екземплярі
//класу викличте метод, який виводить інформацію про адресу.

Address myAddress = new Address() 
{ 
    Country = "Ukraine", 
    City = "Kyiv",
    Street = "North",
    House = 15, 
    Apartment = 23,
    Index = 14214
};

myAddress.ShowAddress();

internal class Address
{
    private string? country;

    private string? city;

    private string? street;

    private int house;

    private int apartment;

    private int index;

    public string? Country 
    { 
        get 
        { 
            return country; 
        } 
        set 
        {
            country = value; 
        } 
    }

    public string? City 
    { 
        get 
        { 
            return city; 
        } 
        set 
        { 
            city = value; 
        } 
    }

    public string? Street 
    { 
        get 
        { 
            return street; 
        } 
        set 
        { 
            street = value; 
        } 
    }

    public int House 
    { 
        get 
        { 
            return house; 
        } 
        set 
        { 
            house = value;
        } 
    }

    public int Apartment 
    {
        get 
        { 
            return apartment; 
        } 
        set 
        { 
            apartment = value; 
        } 
    }

    public int Index 
    { 
        get 
        { 
            return index; 
        } 
        set 
        { 
            index = value; 
        } 
    }

    public void ShowAddress()
    {
        Console.WriteLine($"{country}-{city}-{street}-{house}-{apartment}-{index}");
    }
}