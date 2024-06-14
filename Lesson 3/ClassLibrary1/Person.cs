namespace ClassLibrary1
{
    // Внутрішній клас Person, який наслідує клас Employe
    internal class Person : Employe
    {
        // Автоматично властивість Id
        public int Id { get; set; }

        // Метод для виведення інформації про особу
        public void ShowInfo()
        {
            // Доступ до публічного поля id базового класу Employe
            Console.WriteLine($"{id}");

            // Доступ до захищеного поля name базового класу Employe
            Console.WriteLine($"{name}");

            // Доступ до приватно-захищеного поля secondName базового класу Employe
            Console.WriteLine($"{secondName}");

            // Доступ до захищено-внутрішнього поля salary базового класу Employe
            Console.WriteLine($"{salary}");
        }
    }
}
