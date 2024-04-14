using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_or_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter integer number in range (1, 100):");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput < 1 || userInput > 100)
                {
                    Console.WriteLine("Number should be from 1 to 100!");
                    Console.ReadKey();
                }
                else {
                    string result = CheckNumber(userInput);
                    Console.WriteLine(result);
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You should enter only integer numbers");
                Console.ReadKey();
            }
        }
        public static string CheckNumber(int number) {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else {
                return "Not Fizz, not Buzz";
            }
        }
    }
}
