namespace ClassLibrary1
{
    // Публічний клас Employe, доступний з будь-якої точки програми
    public class Employe
    {
        public int id; // Публічне поле id, доступне з будь-якої точки програми

        private int age; // Приватне поле age, доступне лише всередині класу Employe

        protected string? name; // Захищене поле name, доступне всередині класу Employe і його похідних класів

        private protected string? secondName; // Поле доступне всередині класу та його похідних класів у тому самому збірці

        protected internal int? salary; // Поле доступне всередині збірки і в похідних класах

        internal string? adress; // Поле доступне всередині збірки
    }

    // Клас Info, доступний лише всередині збірки ClassLibrary1
    class Info
    {
        // Метод Show, який демонструє доступ до полів класу Employe
        public void Show()
        {
            Employe employe = new Employe(); // Створення екземпляра класу Employe
            employe.id = 1; // Доступ до публічного поля id
            //employe.age = 10; // Недоступне, оскільки age - приватне поле
            //employe.name = "Alex"; // Недоступне, оскільки name - захищене поле
            //employe.secondName = "Petrov"; // Недоступне, оскільки secondName - приватно-захищене поле
            employe.salary = 100; // Доступ до захищено-внутрішнього поля salary
            employe.adress = "adress"; // Доступ до внутрішнього поля adress
        }
    }
}
