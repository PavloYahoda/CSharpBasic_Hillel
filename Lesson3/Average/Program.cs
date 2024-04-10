using System;


namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                double avg = (firstNumber + secondNumber) / 2;
                Console.WriteLine($"Average is {avg}");
                Console.ReadKey();
            } catch (Exception)
            {
                Console.WriteLine("You are not entering a number");
                Console.ReadKey();
            }
            
        }
    }
}
