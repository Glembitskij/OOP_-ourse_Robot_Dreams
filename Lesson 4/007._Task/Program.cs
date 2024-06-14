// Створення об'єкта класу MyClass
MyClass myClass = new MyClass();

// Upcasting: Приведення до базового класу Object
Object objectMy = myClass;

// Downcasting: Повернення до початкового типу MyClass
MyClass againMyClass = (MyClass)objectMy;



// Клас MyClass, який наслідує клас Object (в C# всі класи наслідуються від Object за замовчуванням)
class MyClass : Object
{
    // Тут можна додати власні поля та методи
}
