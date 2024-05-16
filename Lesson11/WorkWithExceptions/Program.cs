using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter your age: ");
            try
            {
                age = Convert.ToInt32(Console.ReadLine());//default message
                if (age <= 0) throw new FormatException("Age should be greater than zero");//custom message
                Console.WriteLine($"Your age is {age}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
            }
            Console.WriteLine("The program is still running");
            Console.ReadKey();
        }
    }
}
