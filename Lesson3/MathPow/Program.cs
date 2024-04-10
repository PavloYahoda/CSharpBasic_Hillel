using System;


namespace MathPow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter some number: ");
                double userInput = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Your number squared is {Math.Pow(userInput, 2)}");
                Console.ReadKey();
            }
            catch (Exception) {
                Console.WriteLine("You are not entering a number");
                Console.ReadKey();
            }
        }
    }
}
