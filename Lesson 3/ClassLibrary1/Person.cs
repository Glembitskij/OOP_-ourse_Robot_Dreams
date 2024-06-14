namespace ClassLibrary1
{
    internal class Person: Employe
    {
        public int Id { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{id}");
            Console.WriteLine($"{name} ");
            Console.WriteLine($"{secondName} ");
            Console.WriteLine($"{salary} ");
        }
    }
}
