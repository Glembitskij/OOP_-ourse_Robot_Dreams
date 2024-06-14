using ClassLibrary1;

Employe employe = new Employe();
employe.id = 1;
//employe.age = 10; // Не може бути змінене, оскільки це приватне поле
//employe.name = "Alex"; // Не може бути змінене, оскільки це захищене поле
//employe.secondName = "Petrov"; // Не може бути змінене, оскільки це приватно-захищене поле
//employe.salary = 100; // Не може бути змінене, оскільки це захищено-внутрішнє поле
//employe.adress = "adress"; // Не може бути змінене, оскільки це внутрішнє поле

Manager manager = new Manager();
manager.id = 1;
//manager.age = 10; // Не може бути змінене, оскільки це приватне поле
//manager.name = "Alex"; // Не може бути змінене, оскільки це захищене поле
//manager.secondName = "Petrov"; // Не може бути змінене, оскільки це приватно-захищене поле
//manager.salary = 100; // Не може бути змінене, оскільки це захищено-внутрішнє поле
//manager.adress = "adress"; // Не може бути змінене, оскільки це внутрішнє поле

// Оголошення класу Manager, що наслідує клас Employe
class Manager : Employe
{
    // Метод для виведення інформації про менеджера
    public void ShowInfo()
    {
        Console.WriteLine($"{id}"); // Виведення публічного поля id з базового класу Employe
        Console.WriteLine($"{name}"); // Виведення захищеного поля name з базового класу Employe
        //Console.WriteLine($"{age}"); // age не доступне, оскільки це приватне поле
        //Console.WriteLine($"{secondName}"); // secondName не доступне, оскільки це приватно-захищене поле
        Console.WriteLine($"{salary}"); // Виведення захищено-внутрішнього поля salary з базового класу Employe
        //Console.WriteLine($"{adress}"); // adress не доступне, оскільки це внутрішнє поле
    }
}
