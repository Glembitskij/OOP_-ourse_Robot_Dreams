Document document = new Document(); // Створення нового об'єкта класу Document
document.CreateFooter(); // Виклик методу CreateFooter
document.CreateDescription(); // Виклик методу CreateDescription
document.CreateAuthor(); // Виклик методу CreateAuthor
document.CreateFooter(); // Виклик методу CreateFooter ще раз

internal class Document
{
    // Метод для створення заголовка документа
    public void CreateTitle()
    {
        Console.WriteLine("Create Title");
    }

    // Метод для створення опису документа
    public void CreateDescription()
    {
        Console.WriteLine("Create Description");
    }

    // Метод для створення автора документа
    public void CreateAuthor()
    {
        Console.WriteLine("Create Author");
    }

    // Метод для створення нижнього колонтитулу документа
    public void CreateFooter()
    {
        Console.WriteLine("Create Footer");
    }
}
