// Створіть програму в якій опишіть клас, який визначає навчальний клас «ClassRoom»,
// після чого створіть клас студент «Student». У тілі класу створіть наступні методи
// Study(), Read(), Write(), Relax(), всі чотри методи не мають нічого повертати.
// Після чого створіть три дочірні класи відмінний студент - ExcelentStudent,
// нормальний студент - NormalStudent та поганий студент- BadStudent які є
// похідними від базового класу Student і перевизначте кожен із методів,
// залежно від успішності стденту. Конструктор класу ClassRoom має приймає
// аргументи типу Student, клас повинен складатися з максимум з 4-х учнів.
// Подумайте над можливість того, що користувач може передати 2 або 3 аргументи.
// Наведіть інформацію про те, як усі учні екземпляра класу ClassRoom уміють вчитися,
// читати, писати та відпочивати.

// Розв'язок
// Створення студентів різних типів
Student excellentStudent = new ExcelentStudent();
Student normalStudent = new NormalStudent();
Student badStudent = new BadStudent();

// Створення класу та додавання студентів
ClassRoom classRoom = new ClassRoom(excellentStudent, normalStudent, badStudent);

// Виклик методу, який викликає методи у всіх студентів
classRoom.CallMethods();

// Клас, який визначає навчальний клас ClassRoom
internal class ClassRoom
{
    private List<Student> students = new List<Student>();

    // Конструктор класу ClassRoom
    public ClassRoom(params Student[] students)
    {
        // Додавання студентів до списку
        foreach (var student in students)
        {
            if (this.students.Count < 4)
            {
                this.students.Add(student);
            }
            else
            {
                Console.WriteLine("Class is full, cannot add more students.");
                break;
            }
        }
    }

    // Метод для виклику методів усіх студентів
    public void CallMethods()
    {
        foreach (var student in students)
        {
            Console.WriteLine($"\nMethods of {student.GetType().Name}:");
            if (student is ExcelentStudent)
            {
                ExcelentStudent excelentStudent = (ExcelentStudent)student;
                excelentStudent.Study();
                excelentStudent.Read();
                excelentStudent.Write();
                excelentStudent.Relax();
            }
            else if(student is NormalStudent)
            {
                NormalStudent normalStudent = (NormalStudent)student;
                normalStudent.Study();
                normalStudent.Read();
                normalStudent.Write();
                normalStudent.Relax();
            }
            else if (student is BadStudent)
            {
                BadStudent badStudent = (BadStudent)student;
                badStudent.Study();
                badStudent.Read();
                badStudent.Write();
                badStudent.Relax();
            }

        }
    }
}

// Базовий клас Student
internal class Student
{
    public void Study()
    {
        Console.WriteLine("Student is studying.");
    }

    public void Read()
    {
        Console.WriteLine("Student is reading.");
    }

    public void Write()
    {
        Console.WriteLine("Student is writing.");
    }

    public void Relax()
    {
        Console.WriteLine("Student is relaxing.");
    }
}

// Дочірній клас відмінний студент
internal class ExcelentStudent : Student
{
    public new void Study()
    {
        Console.WriteLine("Excelent student is studying intensively.");
    }

    public new void Read()
    {
        Console.WriteLine("Excelent student is reading a lot.");
    }

    public new void Write()
    {
        Console.WriteLine("Excelent student is writing carefully.");
    }

    public new void Relax()
    {
        Console.WriteLine("Excelent student is relaxing a little.");
    }
}

// Дочірній клас нормальний студент
internal class NormalStudent : Student
{
    public new void Study()
    {
        Console.WriteLine("Normal student is studying adequately.");
    }

    public new void Read()
    {
        Console.WriteLine("Normal student is reading regularly.");
    }

    public new void Write()
    {
        Console.WriteLine("Normal student is writing sufficiently.");
    }

    public new void Relax()
    {
        Console.WriteLine("Normal student is relaxing sometimes.");
    }
}

// Дочірній клас поганий студент
class BadStudent : Student
{
    public new void Study()
    {
        Console.WriteLine("Bad student is barely studying.");
    }

    public new void Read()
    {
        Console.WriteLine("Bad student is seldom reading.");
    }

    public new void Write()
    {
        Console.WriteLine("Bad student is writing poorly.");
    }

    public new void Relax()
    {
        Console.WriteLine("Bad student is relaxing most of the time.");
    }
}
