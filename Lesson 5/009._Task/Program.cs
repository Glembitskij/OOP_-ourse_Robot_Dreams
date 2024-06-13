
Person<string> person1 = new Person<string>();
Person<int> person2 = new Person<int>();

class Person<T>
{
    public T? PersonNumber { get; set; }
}
