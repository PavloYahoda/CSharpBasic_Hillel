using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_first_element_to_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = CreateArray(10);
            Console.WriteLine("[{0}]", string.Join(", ", arr));

            int first = GenerateNewElement();
            Console.WriteLine(first);

            int[] changedArr = AddElementToArray(arr, first);
            Console.WriteLine("[{0}]", string.Join(", ", changedArr));

            int[] changedArr2 = AddElementToArrayManually(changedArr, first);
            Console.WriteLine("[{0}]", string.Join(", ", changedArr2));

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

        public static int GenerateNewElement() {
            Random random = new Random();
            int num = random.Next(-100, 101);
            return num;
        }
        public static int[] AddElementToArray(int[] array, int num)
        {
            int[] changedArray = new int[array.Length + 1];
            Array.Copy(array, 0, changedArray, 1, array.Length);
            changedArray[0] = num;
            return changedArray;
        }
        public static int[] AddElementToArrayManually(int[] array, int num)
        {
            int[] changedArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++) {
                changedArray[i + 1] = array[i];
            }

            changedArray[0] = num;
            return changedArray;
        }
    }
}
