using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positive_numbers_in_the_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = CreateArray(10);

            //Output option 1
            Console.Write("[{0}]", string.Join(", ", arr));
            Console.WriteLine(" Positive numbers in the array is/are:  " + countPositiveNumbers(arr));
            
            //Output option 2
            printArray(arr);
            Console.WriteLine("Positive numbers in the array is/are:  " + countPositiveNumbers(arr));

            Console.ReadKey();
        }

        public static int[] CreateArray(int arrayLenght) {
            int[] array = new int[arrayLenght];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++) {
                array[i] = random.Next(-100, 101);
            }
            return array;
        }
        public static int countPositiveNumbers(int[] array)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num > 0) {
                    count++;
                }
            }
            return count;
        }
        public static void printArray(int[] array)
        { 
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}
