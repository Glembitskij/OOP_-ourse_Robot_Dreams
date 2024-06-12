Student student1 = new Student("Vasya", 25);
Student student2 = new Student("Peter", 36);
Student student3 = new Student("Roma", 28);
Student student4 = new Student("Goshа", 19);

Student[] students = new Student[4];

students[0] = student1;
students[1] = student2;
students[2] = student3;
students[3] = student4;

foreach (var student in students)
{
    Console.WriteLine(string.Format(@"студент {1} - його вік {2}", student.Name, student.Age));
}

class Student
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int age;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}