// Шоста парадигма ООП, "перевикористання" (Reuse), означає здатність
// програмних об'єктів і компонентів бути використаними багаторазово
// в різних контекстах або програмах без зміни їхньої основної структури
// або реалізації. Це досягається за допомогою таких механізмів як узагальнення,
// наслідування, композиція, делегування та інші прийоми, що дозволяють
// максимально використовувати існуючі компоненти і об'єкти для створення
// нових функцій або програм.

// Створюємо пару для цілих чисел
Pair<int, string> pair1 = new Pair<int, string>(5, "Hello");

Console.WriteLine("Перша частина пари: " + pair1.First);
Console.WriteLine("Друга частина пари: " + pair1.Second);

// Створюємо пару для рядків
Pair<string, double> pair2 = new Pair<string, double>("Pi value", 3.14);

Console.WriteLine("Перша частина пари: " + pair2.First);
Console.WriteLine("Друга частина пари: " + pair2.Second);


public class Pair<T1, T2>
{
    public T1 First { get; private set; }
    public T2 Second { get; private set; }

    public Pair(T1 first, T2 second)
    {
        First = first;
        Second = second;
    }
}
