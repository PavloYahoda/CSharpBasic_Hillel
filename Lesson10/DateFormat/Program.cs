using System;
using System.Text;
using System.Text.RegularExpressions;


namespace DateFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = {SetDay(), SetMonth(), SetYear()};

            DisplayToConsole(inputArray);
            Console.ReadKey();
        }
        public static string SetDay() {
            while (true)
            {
                Console.Write("Enter date: ");
                string date = Console.ReadLine();
                bool isDateCorrect = Regex.Match(date, @"^(0[1-9]|[12]\d|3[01])$").Success;
                if (isDateCorrect)
                {
                    return date;
                }
                else
                {
                    Console.WriteLine("Date format is incorrect!");
                }
            }
        }
        public static string SetMonth()
        {
            while (true)
            {
                Console.Write("Enter month (please, use digit only): ");
                string month = Console.ReadLine();
                bool isMonthCorrect = Regex.Match(month, @"(^[1-9]$)|(^0[1-9]|1[0-2]$)").Success;
                if (isMonthCorrect)
                {
                    return month;
                }
                else
                {
                    Console.WriteLine("Month format is incorrect!");
                }
            }
        }
        public static string SetYear()
        {
            while (true)
            {
                Console.Write("Enter year (please, use 4-digit format only): ");
                string year = Console.ReadLine();
                bool isYearCorrect = Regex.Match(year, @"^(19|20)\d{2}$").Success;
                if (isYearCorrect)
                {
                    return year;
                }
                else
                {
                    Console.WriteLine("Year format is incorrect! Enter a year between 1900 and 2100");
                }
            }
        }
        public static void DisplayToConsole(string[] inputArray) {
            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < inputArray.Length; i++)
            {
                sb.Append(inputArray[i]);
                if (i < inputArray.Length - 1)
                {
                    sb.Append("-");
                }
            }
            Console.WriteLine($"Entered date is: {sb}"); 
        }
    }
}
