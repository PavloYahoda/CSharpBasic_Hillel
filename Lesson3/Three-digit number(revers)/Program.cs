using System;
using System.Text.RegularExpressions;


namespace Three_digit_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three-digit number: ");
            string userInput = Console.ReadLine();
            if (userInput.Length == 3)
            {
                char[] revers = { userInput[2], userInput[1], userInput[0] };
                string reversedNumber = new string(revers);
                Console.WriteLine($"Reversed number is {reversedNumber}");
                Console.ReadKey();
            }
            else {
                Console.WriteLine("You enter wrong number");
                Console.ReadKey();
            }

        }
    }
}
