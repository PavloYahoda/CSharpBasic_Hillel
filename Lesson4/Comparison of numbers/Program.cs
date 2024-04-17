using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.Write("Enter first number:");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number:");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                string resultOfComparison = ComparisonOfNumbers(firstNumber, secondNumber);
                Console.WriteLine(resultOfComparison);
            }
            catch (Exception ex) {
                Console.WriteLine($"Processing failed: {ex.Message}");
            }
            Console.ReadKey();
        }
        public static string ComparisonOfNumbers(double first, double second) {
            string result;
            if (first == second)
            {
                result = "Numbers are equal";
            }
            else if (first < second)
            {
                result = "First number is less than second";
            }
            else {
                result = "First number is more than second";
            }
            return result;
        }
    }
}
