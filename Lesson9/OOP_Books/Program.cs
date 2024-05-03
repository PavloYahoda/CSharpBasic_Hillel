using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Books
{
    public class Book {
        private string title;
        private string author;
        private int yearOfPublication;
        private int numberOfPages;

        public string Title { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }
        public int NumberOfPages { get; set; }

        public void DisplayInfo() {
            Console.WriteLine($"Title: {Title}\n" +
                $"Author: {Author}\n" +
                $"YearOfPublication: {YearOfPublication}\n" +
                $"NumberOfPages: {NumberOfPages}");
        }
        public void IsThick() {
            if (NumberOfPages > 500)
            {
                Console.WriteLine("This book is thick!");
                Console.WriteLine("");
            }
            else {
                Console.WriteLine("This book is not so thick!");
                Console.WriteLine("");
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book
            {
                Title = "Atlas Shrugged",
                Author = "Ayn Rand",
                YearOfPublication = 1957,
                NumberOfPages = 503
            };

            book1.DisplayInfo();
            book1.IsThick();

            Book book2 = new Book
            {
                Title = "A Brief History of Time",
                Author = "Stephen Hawking",
                YearOfPublication = 1988,
                NumberOfPages = 272
            };

            book2.DisplayInfo();
            book2.IsThick();

            Console.ReadKey();
        }
    }
}
