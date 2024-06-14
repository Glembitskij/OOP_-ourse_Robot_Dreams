//  П'ята парадигма ООП, відома як "відправка повідомлень" (messaging),
//  базується на ідеї, що об'єкти мають можливість взаємодіяти один з одним
//  за допомогою повідомлень. Це означає, що об'єкти взаємодіють, відправляючи
//  один одному повідомлення для виконання певних дій.

Publisher publisher = new Publisher(); // Створення відправника

Subscriber subscriber = new Subscriber(publisher); // Створення підписника

publisher.SendMessage("Hello World!"); // Відправлення повідомлення


// Клас, що містить подію
public class Publisher
{
    // Оголошення події з делегатом EventHandler
    public event EventHandler<MessageEventArgs> MessageSent;

    // Метод, який ініціює відправку повідомлення
    public void SendMessage(string message)
    {
        Console.WriteLine($"Відправлено повідомлення: {message}");

        // Виклик події MessageSent, якщо вона має підписників
        OnMessageSent(message);
    }

    // Метод для сповіщення про подію (генерація події)
    protected virtual void OnMessageSent(string message)
    {
        // Перевірка, чи подія має підписників
        MessageSent?.Invoke(this, new MessageEventArgs(message));
    }
}

// Клас аргументів для події, який містить інформацію про повідомлення
public class MessageEventArgs : EventArgs
{
    public string Message { get; }

    public MessageEventArgs(string message)
    {
        Message = message;
    }
}

// Клас-підписник, який підписується на подію
public class Subscriber
{
    // Конструктор, який підписується на подію при створенні об'єкта
    public Subscriber(Publisher publisher)
    {
        publisher.MessageSent += HandleMessageSent;
    }

    // Обробник події, який викликається при виникненні події
    private void HandleMessageSent(object sender, MessageEventArgs e)
    {
        Console.WriteLine($"Отримано повідомлення: {e.Message}");
    }
}
