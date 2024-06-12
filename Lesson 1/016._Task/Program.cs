MathsLibrary mathsLibrary = new MathsLibrary(152);

//mathsLibrary.field = 15;

Console.WriteLine(mathsLibrary.field);

class MathsLibrary
{
    public readonly double field = 27;

    public MathsLibrary(double fieldValue)
    {
        field = fieldValue;
    }

    public void ChangeField()
    {
        //field = 1949;
    }
}