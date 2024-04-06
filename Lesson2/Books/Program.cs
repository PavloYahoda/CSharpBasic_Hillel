using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookTitle = "Atlas Shrugged";
            string author = "Ayn Rand";
            int yearOfPublication = 1957;
            double price = 326.81;

            Console.WriteLine(String.Format("{0} is a {2} novel by {1}. Now this book cost {3} UAH", bookTitle, author, yearOfPublication, price));
            Console.ReadKey();
        }
    }
}
