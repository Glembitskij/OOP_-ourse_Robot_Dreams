﻿// Створіть програму в якій опишіть клас Document (документ). Даний клас має містити
// три методи void Headline (Заголовок), DocumentСontent (Вміст документ),
// Footer (підвал документа), методи мають бути приватними.
// Після чого в тілі класу створіть публічний метод CreateDocuсment (створити документ),
// в тілі даного методу мають почергово викликатись три приватних методи,
// що були створені раніше. Після чого створіть екземпляр класу Document,
// та на його екземплярі викличте публічний метод CreateDocuсment.
// Передивітся уважно код данної програми та подумайте де саме тут використовується інкапсуляція,
// та що таке інкапсуляція в цілому. 

// Розв'язок
// Створення екземпляра класу "Документ"
Document myDocument = new Document();

// Виклик публічного методу для створення документа
myDocument.CreateDocument();

// Клас "Документ"
class Document
{
    // Приватний метод для заголовка документа
    private void Headline()
    {
        Console.WriteLine("Заголовок документа");
    }

    // Приватний метод для вмісту документа
    private void DocumentContent()
    {
        Console.WriteLine("Вміст документа");
    }

    // Приватний метод для підвалу документа
    private void Footer()
    {
        Console.WriteLine("Підвал документа");
    }

    // Публічний метод для створення документа, який викликає три приватні методи
    public void CreateDocument()
    {
        Headline();
        DocumentContent();
        Footer();
    }
}