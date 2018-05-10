using System;

namespace Lesson_6
{
    class Program
    {
        //static string[] BookNames;
        //static string[] BookAuthors;
        //static int[] BookYear;
        static int[] BookCost;

        static void Main(string[] args)
        {
            Book book1 = new Book("Тестовое название", "Тестовый автор", 1966, 777);
            book1.ShowInfo();

            Book book2 = new Book();
            book2.Name = "Some nane";
            book2.Author = "Some author";
            book2.Year = 1999;
            book2.Cost = 157;
            book2.ShowInfo();

            Program p = new Program();

            #region Old

            //BookNames = new string[5];
            //BookAuthors = new string[5];
            //BookYear = new int[5];
            //BookCost = new int[5];

            //BookNames[0] = "Какое-то название";
            //BookAuthors[0] = "Какой-то автор";
            //BookYear[0] = 2000;
            //BookCost[0] = 150;

            //ShowBookInfo(BookNames[0], BookAuthors[0], BookYear[0], BookCost[0]);

            #endregion

            Console.ReadLine();
        }

        static void BuyBook(string bookName, int bookCost)
        {
            // Покупка книги покупателем
        }

        //static void ShowBookInfo(string bookName, string bookAuthor, int bookYear, int bookCost)
        //{
        //    Console.WriteLine("Книга '{0}' (автор {1}) была издана в {2} году. Цена {3}", bookName, bookAuthor, bookYear, bookCost);
        //}

    }

    class Book
    {
        // Поле структуры
        public string Name;
        public string Author;
        public int Year;
        public int Cost;

        // Метод структуры
        public void ShowInfo()
        {
            Console.WriteLine("Книга '{0}' (автор {1}) была издана в {2} году. Цена {3}", Name, Author, Year, Cost);
        }

        // Конструктор
        public Book()
        {
            // Конструктор позволяет создать объект и инициализировать переменные объекта начальными значениями
        }

        public Book(string name, string author, int year, int cost)
        {
            Name = name;
            Author = author;
            Year = year;
            Cost = cost;
        }
    }

    class Person
    {
        string Name;
        int Age;

        void ShowInfo()
        {
            Console.WriteLine("Человек по имени '{0}', возрастом {1} лет/год.", Name, Age);
        }
    }
}