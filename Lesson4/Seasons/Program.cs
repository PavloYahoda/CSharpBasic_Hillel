using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seasons
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number of month:");
                int numberOfMonth = Convert.ToInt32(Console.ReadLine());
                switch (numberOfMonth)
                {
                    case 1:
                    case 2:
                    case 12:
                        Console.WriteLine("Winter");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Spring");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Summer");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Autumn");
                        break;
                    default:
                        Console.WriteLine("There is no such moon on this planet");
                        break;
                }        
            }
            catch (Exception ex) {
                Console.WriteLine($"Processing failed: {ex.Message}");
            }
        Console.ReadKey();
        }
    }
}
