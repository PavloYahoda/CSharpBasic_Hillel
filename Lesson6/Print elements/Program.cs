using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = CreateArray(10);
            Console.WriteLine("[{0}]", string.Join(", ", arr));

            PrintElements(arr);

            Console.ReadKey();
        }
        public static int[] CreateArray(int arrayLenght)
        {
            int[] array = new int[arrayLenght];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-5, 6);
            }
            return array;
        }

        public static void PrintElements(int[] array) {
            for (int i = 0; i < array.Length; i++) {
                if (array[i] == -1)
                {
                    break;
                }
                else {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
