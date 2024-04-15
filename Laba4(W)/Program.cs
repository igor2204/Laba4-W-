using LibraryReaderNamespace;
using StudentNamespace;

namespace StudentNamespace
{
    class Student
    {
        public string Name { get; set; }
        public string GroupNumber { get; set; }
        private int Age { get; set; }

        public Student(string name, string groupNumber, int age)
        {
            Name = name;
            GroupNumber = groupNumber;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {Name}\nГруппа: {GroupNumber}\nВозраст: {Age}");
        }
    }
}

namespace LibraryReaderNamespace
{
    class Reader
    {
        private string FullName { get; set; }
        public int LibraryCardNumber { get; set; }
        public string Faculty { get; set; }
        private DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }

        public Reader(string fullName, int cardNumber, string faculty, DateTime dateOfBirth, string phone)
        {
            FullName = fullName;
            LibraryCardNumber = cardNumber;
            Faculty = faculty;
            DateOfBirth = dateOfBirth;
            Phone = phone;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Читатель: {FullName}\nНомер билета: {LibraryCardNumber}\nФакультет: {Faculty}\nДата рождения: {DateOfBirth:dd/MM/yyyy}\nТелефон: {Phone}");
        }

        public void TakeBook(int numberOfBooks)
        {
            Console.WriteLine($"{FullName} взял {numberOfBooks} книги.");
        }

        public void TakeBook(params string[] bookNames)
        {
            Console.WriteLine($"{FullName} взял книги:");
            foreach (var book in bookNames)
            {
                Console.WriteLine(book);
            }
        }

        public void ReturnBook(int numberOfBooks)
        {
            Console.WriteLine($"{FullName} вернул {numberOfBooks} книги.");
        }

        public void ReturnBook(params string[] bookNames)
        {
            Console.WriteLine($"{FullName} вернул книги:");
            foreach (var book in bookNames)
            {
                Console.WriteLine(book);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        // Создаем студентов
        var students = new Student[]
        {
            new Student("Иванов А.А.", "Группа 1", 20),
            new Student("Петров Б.В.", "Группа 2", 21),
            new Student("Сидоров В.С.", "Группа 3", 22),
            new Student("Смирнов А.А.", "Группа 4", 20)
        };

        // Создание читателей библиотеки
        var readers = new Reader[]
        {
            new Reader("Иванов Андрей", 12345, "Исторический", new DateTime(1990, 5, 15), "+9375461222"),
            new Reader("Петров Василий", 54321, "Химический", new DateTime(1985, 10, 20), "+9876543219"),
            new Reader("Сидоров Сергей", 98765, "Физический", new DateTime(1995, 3, 25), "+9630981277"),
            new Reader("Смирнов Александр", 45677, "Медицинский", new DateTime(1993, 5, 17), "+9265646634")
        };

        // Пример использования методов
        readers[0].TakeBook(3);
        readers[1].TakeBook("Приключения", "Словарь", "Энциклопедия");
        readers[2].ReturnBook("Путешествия", "Роман");
        readers[3].ReturnBook(2);
    }
}
