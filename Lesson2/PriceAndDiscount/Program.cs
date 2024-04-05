using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceAndDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the price, please: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the discount percentage: ");
            int discountInPercent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your discount is {price*discountInPercent/100}");
            Console.ReadKey();
        }
    }
}
