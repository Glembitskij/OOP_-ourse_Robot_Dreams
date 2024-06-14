// Присвоєння значення константі Pi у класі MathsLibrary
// Це намагання змінити значення константи буде неуспішним,
// оскільки константа Pi є незмінною (const).
// MathsLibrary.Pi = 3.14;

// Виведення значення константи Pi на консоль
Console.WriteLine(MathsLibrary.Pi);

class MathsLibrary
{
    // Константа Pi зі значенням 3.141
    public const double Pi = 3.141;

    // Конструктор класу MathsLibrary, який приймає параметр Pi.
    // Проте константу не можна змінити після ініціалізації.
    public MathsLibrary(double Pi)
    {
        //this.Pi = Pi;
    }
}
