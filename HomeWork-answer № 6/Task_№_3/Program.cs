// Створіть базовий абстрактний клас Document (документ), в якому створіть три методи
// void Headline (Заголовок), DocumentSontent (Вміст документу),
// Footer (підвал документа). Реалізуйте конкретний клас, який успадковується
// від дочірнього класу Document, і в  тілі класу реалізуйте всі методи
// абстрактного класу. (Реалізація може включитися в простому виведенні інформації
// про те, яка це частина документа.)

// Розв'язок
// Створення екземпляру конкретного документа
ConcreteDocument document = new ConcreteDocument();

// Виклик методів документа для відображення
document.Headline();
document.DocumentContent();
document.Footer();

// Базовий абстрактний клас Document
internal abstract class Document
{
    // Абстрактні методи, які будуть реалізовані в похідних класах
    public abstract void Headline();
    public abstract void DocumentContent();
    public abstract void Footer();
}

// Конкретний клас, що успадковується від Document
internal class ConcreteDocument : Document
{
    // Реалізація методу Headline
    public override void Headline()
    {
        Console.WriteLine("Заголовок документа");
    }

    // Реалізація методу DocumentContent
    public override void DocumentContent()
    {
        Console.WriteLine("Вміст документа");
    }

    // Реалізація методу Footer
    public override void Footer()
    {
        Console.WriteLine("Підвал документа");
    }
}