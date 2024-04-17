using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "root";
            string user_input;
            while (true)
            {
                Console.Write("Enter password: ");
                user_input = Console.ReadLine();
                if (user_input == pass)
                {
                    Console.WriteLine("You are hacker!");
                    break;
                }
                else {
                    Console.WriteLine("Password is wrong!");
                }
            }
            Console.ReadKey();
        }
    }
}
