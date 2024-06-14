MathsLibrary mathsLibrary = new MathsLibrary(152);

// Намагаємося присвоїти значення полю field після ініціалізації. 
// Однак, поле field оголошено як readonly і може бути ініціалізоване 
// тільки один раз в конструкторі або при оголошенні.
// mathsLibrary.field = 15;

// Виведення значення поля field на консоль.
Console.WriteLine(mathsLibrary.field);

class MathsLibrary
{
    // Поле field оголошено як readonly і ініціалізується значенням 27.
    public readonly double field = 27;

    // Конструктор класу MathsLibrary, який приймає параметр fieldValue
    // і присвоює його полю field. Оскільки field є readonly,
    // воно може бути ініціалізоване лише один раз.
    public MathsLibrary(double fieldValue)
    {
        field = fieldValue;
    }

    // Метод, який намагається змінити значення поля field.
    // Однак, це неможливо, оскільки field є readonly.
    public void ChangeField()
    {
        //field = 1949;
    }
}
