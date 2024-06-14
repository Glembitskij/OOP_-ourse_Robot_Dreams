namespace ClassLibrary1
{
    public class Employe
    {
        public int id;

        private int age;

        protected string? name;

        private protected string? secondName;

        protected internal int? salary;

        internal string? adress;
    }

    class Info
    {
        public void Show()
        {
            Employe employe = new Employe();
            employe.id = 1;
            //employe.age = 10;
            //employe.name = "Alex";
            //employe.secondName = "Petrov";
            employe.salary = 100;
            employe.adress = "adress";
        }
    }
}
