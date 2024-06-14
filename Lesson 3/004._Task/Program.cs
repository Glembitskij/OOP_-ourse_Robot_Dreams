Document document = new Document(); // Створення нового об'єкта класу Document
document.CreateDocument(); // Виклик методу CreateDocument

internal class Document
{
    // Публічний метод, який створює документ, викликаючи інші методи для створення його частин
    public void CreateDocument()
    {
        CreateFooter(); // Виклик приватного методу CreateFooter
        CreateDescription(); // Виклик приватного методу CreateDescription
        CreateAuthor(); // Виклик приватного методу CreateAuthor
        CreateFooter(); // Виклик приватного методу CreateFooter ще раз
    }

    // Приватний метод для створення заголовка документа
    private void CreateTitle()
    {
        Console.WriteLine("Create Title");
    }

    // Приватний метод для створення опису документа
    private void CreateDescription()
    {
        Console.WriteLine("Create Description");
    }

    // Приватний метод для створення автора документа
    private void CreateAuthor()
    {
        Console.WriteLine("Create Author");
    }

    // Приватний метод для створення нижнього колонтитулу документа
    private void CreateFooter()
    {
        Console.WriteLine("Create Footer");
    }
}
