// Створення студентів з використанням конструктора
Student student1 = new Student("Vasya", 25);
Student student2 = new Student("Peter", 36);
Student student3 = new Student("Roma", 28);
Student student4 = new Student("Goshа", 19);

// Створення масиву студентів та заповнення його об'єктами
Student[] students = new Student[4];
students[0] = student1;
students[1] = student2;
students[2] = student3;
students[3] = student4;

// Виведення інформації про кожного студента з масиву
foreach (var student in students)
{
    Console.WriteLine($"студент {student.Name} - його вік {student.Age}");
}

class Student
{
    private string name; // Поле для зберігання імені студента

    public string Name // Властивість для доступу до імені студента
    {
        get { return name; }
        set { name = value; }
    }

    private int age; // Поле для зберігання віку студента

    public int Age // Властивість для доступу до віку студента
    {
        get { return age; }
        set { age = value; }
    }

    // Конструктор класу Student, який приймає параметри name і age
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
