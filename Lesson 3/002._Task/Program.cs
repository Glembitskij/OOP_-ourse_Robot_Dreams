using ClassLibrary1;

Employe employe = new Employe();
employe.id = 1;
//employe.age = 10;
//employe.name = "Alex";
//employe.secondName = "Petrov";
//employe.salary = 100;
//employe.adress = "adress";

Manager manager = new Manager();
manager.id = 1;
//manager.age = 10;
//manager.name = "Alex";
//manager.secondName = "Petrov";
//manager.salary = 100;
//manager.adress = "adress";

class Manager: Employe
{
    public void ShowInfo()
    {
        Console.WriteLine($"{id}");
        Console.WriteLine($"{name}");
        //Console.WriteLine($"{age}");
        //Console.WriteLine($"{secondName}");
        Console.WriteLine($"{salary}");
        //Console.WriteLine($"{adress}");
    }
}