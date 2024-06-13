// Наслідування один із основних принципів об'єктно-орієнтованого програмування,
// завдяки цій парадигмі можливе створення ієрархічних класифікацій.
// За допомогою наслідуванню можна створити загальний клас, у якому визначаються
// характерні особливості, властиві безлічі зв'язаних елементів. Від цього класу
// можуть унаслідуватись інші, більш конкретні класи, при цьому додаючи свої
// індивідуальні особливості.

Transport transport = new Transport();
transport.Name = "bicycle";
transport.Run();

Terrestrial terrestrial = new Terrestrial();
terrestrial.Name = "Bus";
terrestrial.TransportType = "Passenger";
terrestrial.Run();
terrestrial.ShowTransportType();

internal class Transport
{
    public string? Name { get; set; }

    public void Run()
    {
        Console.WriteLine($"{Name} - transport run!");
    }
}

internal class Terrestrial: Transport
{
    public string? TransportType { get; set; }

    public void ShowTransportType()
    {
        Console.WriteLine($"{Name} - {TransportType}");
    }
}

internal class Water: Transport
{

}

internal class Air : Transport
{

}

