using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Books
{    
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

            book1.DisplayConsoleBookInfo(book1.GetBookInfo());
            book1.DisplayConsoleIsThick(book1.IsThick());

            Book book2 = new Book
            {
                Title = "A Brief History of Time",
                Author = "Stephen Hawking",
                YearOfPublication = 1988,
                NumberOfPages = 272
            };

            book2.DisplayConsoleBookInfo(book2.GetBookInfo());
            book2.DisplayConsoleIsThick(book2.IsThick());

            Console.ReadKey();
        }
    }
}
