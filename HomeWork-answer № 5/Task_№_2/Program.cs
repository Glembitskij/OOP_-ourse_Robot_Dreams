// Створіть програму, в якій створіть базовий клас Person (людина),
// у класі створіть поле типу int з ім'ям BirthYear (рік народження), а також поле
// типу string з ім'ям Name та поле типу string з ім'ям Surname.
// Після чого створіть клас Student (студент) та клас Teacher (викладач).
// У класі Student додайте поле типу string[] з ім'ям Study Courses (курси, що вивчаються),
// властивість (не авто властивість) для додавання (set) і отримання (get) курсів,
// що вивчаються, і метод DisplayStudyСourses() з повертаймим значенням void,
// який буде виводити на консоль всі предмети та максимальну кількість курсів,
// що вивчаються (максимальна кількість може бути 3). У класі викладач створити поле т
// ипу Student[] з ім'ям StudentsArray, і властивість (не авто властивість) для додавання
// (set) і отримання (get) студентів. Створіть 5 екземплярів класу типу Student та ініціалізуйте
// їх довільними значеннями, та 2 екземпляри класу типу Teacher, ініціалізуйте їх довільними
// значеннями (для ініціалізації поля StudentsArray використовуйте вже створені екземпляри
// Student). Далі створіть клас PeopleInfo, у ньому створіть поле типу Person[] з ім'ям
// PeopleArray та властивість (не авто властивість) для додавання (set) та отримання (get)
// людей та метод який буде виводити всіх людей який є у полі PeopleInfo.

// Розв'язок
// Створення студентів
Student student1 = new Student { Name = "John", Surname = "Doe", BirthYear = 2000 };
student1.StudyCourses = new string[] { "Math", "Physics" };

Student student2 = new Student { Name = "Alice", Surname = "Smith", BirthYear = 1999 };
student2.StudyCourses = new string[] { "History", "Biology" };

Student student3 = new Student { Name = "Bob", Surname = "Johnson", BirthYear = 2001 };
student3.StudyCourses = new string[] { "English", "Chemistry" };

Student student4 = new Student { Name = "Emily", Surname = "Davis", BirthYear = 2002 };
student4.StudyCourses = new string[] { "Art", "Music" };

Student student5 = new Student { Name = "Michael", Surname = "Brown", BirthYear = 1998 };
student5.StudyCourses = new string[] { "Computer Science", "Geography" };

// Створення викладачів
Teacher teacher1 = new Teacher { Name = "Prof", Surname = "Smith", BirthYear = 1975 };
teacher1.StudentsArray = new Student[] { student1, student2, student3 };

Teacher teacher2 = new Teacher { Name = "Dr", Surname = "Johnson", BirthYear = 1980 };
teacher2.StudentsArray = new Student[] { student4, student5 };

// Створення PeopleInfo та ініціалізація людей
PeopleInfo peopleInfo = new PeopleInfo();
peopleInfo.PeopleArray = new Person[] { student1, student2, student3, student4, student5, teacher1, teacher2 };

// Виведення інформації про всіх людей
Console.WriteLine("Information about all people:");
peopleInfo.DisplayPeople();

// Виведення курсів, які вивчає перший студент
student1.DisplayStudyCourses();

// Базовий клас Person (людина)
internal class Person
{
    public int BirthYear { get; set; } // Рік народження
    public string? Name { get; set; }   // Ім'я
    public string? Surname { get; set; } // Прізвище
}

// Клас Student (студент), успадковує Person
internal class Student : Person
{
    private string[] studyCourses = new string[3]; // Масив для зберігання курсів

    // Властивість для доступу до курсів, що вивчаються
    public string[] StudyCourses
    {
        get { return studyCourses; }
        set { studyCourses = value; }
    }

    // Метод для виведення курсів, що вивчаються
    public void DisplayStudyCourses()
    {
        Console.WriteLine($"Student {Name} {Surname} is studying:");
        foreach (var course in studyCourses)
        {
            if (!string.IsNullOrEmpty(course))
            {
                Console.WriteLine(course);
            }
        }
    }
}

// Клас Teacher (викладач), успадковує Person
internal class Teacher : Person
{
    private Student[] studentsArray = new Student[5]; // Масив для зберігання студентів

    // Властивість для доступу до студентів
    public Student[] StudentsArray
    {
        get { return studentsArray; }
        set { studentsArray = value; }
    }
}

// Клас PeopleInfo
internal class PeopleInfo
{
    private Person[]? peopleArray; // Масив для зберігання людей

    // Властивість для доступу до людей
    public Person[]? PeopleArray
    {
        get { return peopleArray; }
        set { peopleArray = value; }
    }

    // Метод для виведення інформації про всіх людей
    public void DisplayPeople()
    {
        if (peopleArray == null) {
            return;
        }

        foreach (var person in peopleArray)
        {
            Console.WriteLine($"Name: {person.Name}, Surname: {person.Surname}, BirthYear: {person.BirthYear}");
        }
    }
}
