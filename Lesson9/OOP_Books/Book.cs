using System;

namespace OOP_Books
{
    public class Book
    {
        private string title;
        private string author;
        private int yearOfPublication;
        private int numberOfPages;

        public string Title { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }
        public int NumberOfPages { get; set; }

        public string GetBookInfo()
        {
            return $"Title: {Title}\n" +
                $"Author: {Author}\n" +
                $"YearOfPublication: {YearOfPublication}\n" +
                $"NumberOfPages: {NumberOfPages}";
        }
        public void DisplayConsoleBookInfo(string bookInfo)
        {
            Console.WriteLine(bookInfo);
        }
        public bool IsThick()
        {
            if (NumberOfPages > 500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DisplayConsoleIsThick(bool isThick)
        {
            if (isThick)
            {
                Console.WriteLine("This book is thick!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("This book is not so thick!");
                Console.WriteLine();
            }
        }
    }
}
