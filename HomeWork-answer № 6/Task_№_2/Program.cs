// Створіть програму в якій створіть абстрактний клас Device.
// Даний клас має містити два абстрактних методи TurnOn() та TurnOff().
// Після чого створіть інтерфейс ISmartDevice, який містить метод ConnectToWifi().
// Потім створіть класи Smartphone і SmartTV, які наслідуються від класу Device
// та реалізують інтерфейс ISmartDevice. Реалізуйте відповідні методи для обох класів.
// Створіть екземпляри цих класів і продемонструйте їх використання.

// Розв'язок
// Створення екземпляру смартфона
Smartphone smartphone = new Smartphone();
smartphone.TurnOn();
smartphone.ConnectToWifi();
smartphone.TurnOff();

Console.WriteLine();

// Створення екземпляру смарттелевізора
SmartTV smartTV = new SmartTV();
smartTV.TurnOn();
smartTV.ConnectToWifi();
smartTV.TurnOff();

// Абстрактний клас Device
internal abstract class Device
{
    // Абстрактні методи
    public abstract void TurnOn();
    public abstract void TurnOff();
}

// Інтерфейс ISmartDevice
public interface ISmartDevice
{
    void ConnectToWifi();
}

// Клас Smartphone, що наслідується від Device та реалізує ISmartDevice
internal class Smartphone : Device, ISmartDevice
{
    // Реалізація абстрактного методу TurnOn для смартфона
    public override void TurnOn()
    {
        Console.WriteLine("Smartphone is turning on");
    }

    // Реалізація абстрактного методу TurnOff для смартфона
    public override void TurnOff()
    {
        Console.WriteLine("Smartphone is turning off");
    }

    // Реалізація методу ConnectToWifi інтерфейсу ISmartDevice для смартфона
    public void ConnectToWifi()
    {
        Console.WriteLine("Smartphone is connecting to WiFi");
    }
}

// Клас SmartTV, що наслідується від Device та реалізує ISmartDevice
internal class SmartTV : Device, ISmartDevice
{
    // Реалізація абстрактного методу TurnOn для смарттелевізора
    public override void TurnOn()
    {
        Console.WriteLine("Smart TV is turning on");
    }

    // Реалізація абстрактного методу TurnOff для смарттелевізора
    public override void TurnOff()
    {
        Console.WriteLine("Smart TV is turning off");
    }

    // Реалізація методу ConnectToWifi інтерфейсу ISmartDevice для смарттелевізора
    public void ConnectToWifi()
    {
        Console.WriteLine("Smart TV is connecting to WiFi");
    }
}