using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_digit_number__replace_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter three-digit number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (100 <= userInput & userInput <= 999)
                {
                    int units = userInput % 10;
                    int tens = userInput / 10 % 10;
                    int hundreds = userInput / 100;
                    int changedNumber = tens * 100 + hundreds * 10 + units;
                    Console.WriteLine($"Changed number is {changedNumber}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You enter wrong number");
                    Console.ReadKey();
                }
            }
            catch (Exception) {
                Console.WriteLine("You are not entering a number");
                Console.ReadKey();
            }
            
        }
    }
}
