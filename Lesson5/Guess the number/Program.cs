using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int correctAnswer = random.Next(1, 146);
            int user_input;
            bool isAnswerСorrect = true;
            try
            {
                while (isAnswerСorrect)
                {
                    Console.Write("Enter number from 1 to 146: ");
                    user_input = Convert.ToInt32(Console.ReadLine());
                    if (user_input > 0 && user_input < 147)
                    {
                        int result = Math.Abs(correctAnswer - user_input);
                        switch (result)
                        {
                            case var n when n > 10:
                                Console.WriteLine("Cold");
                                break;
                            case var n when n >= 5 && n <= 10:
                                Console.WriteLine("Cool");
                                break;
                            case var n when n > 0 && n < 5:
                                Console.WriteLine("Hot");
                                break;
                            case var n when n == 0:
                                Console.WriteLine("You won!");
                                isAnswerСorrect = false;
                                break;
                        }
                    }
                    else {
                        Console.WriteLine("You should enter number from 1 to 146");
                    }
                }
                    
            }
            catch (Exception ex) {
                Console.WriteLine($"Processing failed: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
