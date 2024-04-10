using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_vars
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"Before changes: a = {a}, b = {b}");
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine($"After changes: a = {a}, b = {b}");
            Console.ReadKey();
        }
    }
}
