// Наслідування один із основних принципів об'єктно-орієнтованого програмування,
// завдяки цій парадигмі можливе створення ієрархічних класифікацій.
// За допомогою наслідуванню можна створити загальний клас, у якому визначаються
// характерні особливості, властиві безлічі зв'язаних елементів. Від цього класу
// можуть унаслідуватись інші, більш конкретні класи, при цьому додаючи свої
// індивідуальні особливості.

// Створення об'єкта класу Transport
Transport transport = new Transport();
// Встановлення імені транспортного засобу
transport.Name = "bicycle";
// Виклик методу Run для транспортного засобу
transport.Run();

// Створення об'єкта класу Terrestrial
Terrestrial terrestrial = new Terrestrial();
// Встановлення імені транспортного засобу
terrestrial.Name = "Bus";
// Встановлення типу наземного транспортного засобу
terrestrial.TransportType = "Passenger";
// Виклик методу Run для наземного транспортного засобу
terrestrial.Run();
// Виклик методу ShowTransportType для відображення типу транспортного засобу
terrestrial.ShowTransportType();

// Базовий клас Transport
internal class Transport
{
    // Властивість для зберігання імені транспортного засобу
    public string? Name { get; set; }

    // Метод для запуску транспортного засобу
    public void Run()
    {
        Console.WriteLine($"{Name} - transport run!");
    }
}

// Клас Terrestrial, що наслідує клас Transport
internal class Terrestrial : Transport
{
    // Властивість для зберігання типу наземного транспортного засобу
    public string? TransportType { get; set; }

    // Метод для відображення типу транспортного засобу
    public void ShowTransportType()
    {
        Console.WriteLine($"{Name} - {TransportType}");
    }
}

// Клас Water, що наслідує клас Transport
internal class Water : Transport
{
    // Додаткові методи та властивості для водного транспорту можна додати тут
}

// Клас Air, що наслідує клас Transport
internal class Air : Transport
{
    // Додаткові методи та властивості для повітряного транспорту можна додати тут
}

