using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //1) Фільтрація: Дано список цілих чисел: {2, 5, 8, 12, 15, 18, 22}. Відфільтруйте всі числа, які більше 10.

            int[] arr = { 2, 5, 8, 12, 15, 18, 22 };
            var result = arr.Where(x => x > 10).ToList();
            Console.WriteLine("[{0}]", string.Join(", ", result));
            Console.WriteLine("--------------------");

            //2) Сортування: Дано список імен фруктів: {"Яблуко", "Апельсин", "Банан", "Ківі"}. Відсортуйте цей список в алфавітному порядку.

            List<string> listNames = new List<string>() { "Яблуко", "Апельсин", "Банан", "Ківі" };
            var resultOrdered = listNames.OrderBy(n => n);
            Console.WriteLine(string.Join(", ", resultOrdered));
            Console.WriteLine("--------------------");

            //3) Видалення дублікатів: Дано список рядків: {"А", "Б", "В", "А", "Г", "В"}. Видаліть всі дублікати і поверніть унікальні рядки.

            List<string> listAbc = new List<string>() { "А", "Б", "В", "А", "Г", "В" };
            var resultAsSet = listAbc.Distinct();
            Console.WriteLine(string.Join(", ", resultAsSet));
            Console.WriteLine("--------------------");

            //4) Підрахунок: Дано список оцінок студентів {85, 92, 78, 95, 88, 90}. Порахуйте, скільки студентів отримали більше 90 балів.
            List<int> listEvaluations = new List<int>() { 85, 92, 78, 95, 88, 90 };
            var count = listEvaluations.Where(x => x > 90).ToList().Count;
            Console.WriteLine(count);
            Console.WriteLine("--------------------");

            //5) Фільтрація та сортування: Дано список об'єктів, які представляють товари і мають поля "Назва" і "Ціна".
            //   Відфільтруйте товари, які мають ціну менше 50 гривень і відсортуйте їх за зростанням ціни.

                        
            List<Product> products = new List<Product>
                {
                    new Product { Name = "Prod1", Price = 20 },
                    new Product { Name = "Prod2", Price = 160 },
                    new Product { Name = "Prod3", Price = 35 },
                    new Product { Name = "Prod4", Price = 178 }
                };
            var result2 = products.Where(product => product.Price < 50)
                                                    .OrderBy(product => product.Price);

            foreach (var product in result2)
            {
                Console.WriteLine($"Назва: {product.Name}, Ціна: {product.Price} грн");
            }
            Console.WriteLine("--------------------");

            //6) Пошук максимального за індексом: Дано список цілих чисел {10, 25, 8, 45, 15, 30, 55, 5}. Знайдіть максимальне число за індексом (позицією) в списку.

            List<int> numbers = new List<int> { 10, 25, 8, 45, 15, 30, 55, 5 };
            int maxNumberIndex = numbers.IndexOf(numbers.Max());
            Console.WriteLine(maxNumberIndex);
            Console.WriteLine("--------------------");

            //7

            List<Student> students = new List<Student>
                {
                    new Student { Name = "Pavlo", Grade = 97, Course = "First" },
                    new Student { Name = "Bohdan", Grade = 99, Course = "Second" },
                    new Student { Name = "Andrii", Grade = 91, Course = "Third" },
                    new Student { Name = "Svitlana", Grade = 83, Course = "First" },
                    new Student { Name = "Nina", Grade = 96, Course = "Second" },
                    new Student { Name = "Alex", Grade = 92, Course = "Third" }
                };

            // Grade >= 90
            var highGrade = students.Where(student => student.Grade >= 90).ToList();
            foreach (var student in highGrade)
            {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Course: {student.Course}");
            }
            Console.WriteLine();
            Console.WriteLine("***");

            // Desc Grade
            var descGrade = students.OrderByDescending(student => student.Grade).ToList();
            foreach (var student in descGrade)
            {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Course: {student.Course}");
            }
            Console.WriteLine();
            Console.WriteLine("***");

            // Group by course
            var byCourse = students.GroupBy(student => student.Course).ToList();

            foreach (var group in byCourse)
            {
                Console.WriteLine($"Course: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***");

            // Count on course
            var countByCourse = students.GroupBy(student => student.Course)
                                        .Select(group => new { Course = group.Key, Count = group.Count() });

            Console.WriteLine("Count on course:");
            foreach (var item in countByCourse)
            {
                Console.WriteLine($"Course: {item.Course}, Count: {item.Count}");
            }
            Console.WriteLine();
            Console.WriteLine("***");

            // Projection
            var projection = students.Select(student => $"Name: {student.Name}, Grade: {student.Grade}");

            Console.WriteLine("Projection:");
            foreach (var item in projection)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
    public class Product { 
        public string Name { get; set; }
        public int Price { get; set; }
    }
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Course { get; set; }
    }
}
