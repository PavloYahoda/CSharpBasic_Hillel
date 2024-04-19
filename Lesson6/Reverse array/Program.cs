using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_array
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] arr = CreateArray(11);
            Console.WriteLine("This is old array: ");
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            Console.WriteLine();

            Console.WriteLine("This is new reversed array: ");
            Console.WriteLine("[{0}]", string.Join(", ", CreateReversedArrey(arr)));
            Console.WriteLine();

            ReverseArrayByBuffer(arr);
            Console.WriteLine("This is old reversed array: ");
            Console.WriteLine("[{0}]", string.Join(", ", arr));

            Console.ReadKey();
        }
        public static int[] CreateArray(int arrayLenght)
        {
            int[] array = new int[arrayLenght];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
            }
            return array;
        }
        public static int[] CreateReversedArrey(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[reversedArray.Length - 1 - i] = array[i];
            }
            return reversedArray;
        }

        public static int[] ReverseArrayByBuffer(int[] array) {
            for (int i = 0; i < (array.Length)/2; i++) {
                int buffer = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = buffer;
            }
            return array;
        }
        
    }
}
