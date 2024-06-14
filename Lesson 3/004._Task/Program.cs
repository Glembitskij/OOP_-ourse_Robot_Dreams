Document document = new Document();
document.CreateDocument();

internal class Document
{
    public void CreateDocument()
    {
        CreateFooter();
        CreateDescription();
        CreateAuthor();
        CreateFooter();
    }

    private void CreateTitle()
    {
        Console.WriteLine("Create Title");
    }

    private void CreateDescription()
    {
        Console.WriteLine("Create Description");
    }

    private void CreateAuthor()
    {
        Console.WriteLine("Create Author");
    }

    private void CreateFooter()
    {
        Console.WriteLine("Create Footer");
    }
}
