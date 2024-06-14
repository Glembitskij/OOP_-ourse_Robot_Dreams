Document document = new Document();
document.CreateFooter();
document.CreateDescription();
document.CreateAuthor();
document.CreateFooter();

internal class Document
{
    public void CreateTitle()
    {
        Console.WriteLine("Create Title");
    }

    public void CreateDescription() 
    {
        Console.WriteLine("Create Description");
    }

    public void CreateAuthor() 
    {
        Console.WriteLine("Create Author");
    }

    public void CreateFooter()
    {
        Console.WriteLine("Create Footer");
    }
}
