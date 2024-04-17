using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{j} * {i} = {i * j}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 6; j <= 10; j++)
                {
                    Console.Write($"{j} * {i} = {i * j}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
