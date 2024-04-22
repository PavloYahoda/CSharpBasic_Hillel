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
            PrintArray(arr);

            int first = GenerateNewElement();
            Console.WriteLine(first);

            int[] extendedArr = ExtendArray(arr, 1);
            int[] changedArr = AddElementToArray(extendedArr, first);
            PrintArray(changedArr);

            int[] extendedArr2 = ExtendArrayManually(arr, 1);
            int[] changedArr2 = AddElementToArray(extendedArr2, first);
            PrintArray(changedArr2);

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
        public static int[] ExtendArray(int[] array, int additionalSize)
        {
            int[] changedArray = new int[array.Length + additionalSize];
            Array.Copy(array, 0, changedArray, 1, array.Length);
            return changedArray;
        }
        public static int[] ExtendArrayManually(int[] array, int additionalSize)
        {
            int[] changedArray = new int[array.Length + additionalSize];
            for (int i = 0; i < array.Length; i++)
            {
                changedArray[i + 1] = array[i];
            }
            return changedArray;
        }

        public static int[] AddElementToArray(int[] array, int num)
        {
            array[0] = num;
            return array;
        }
        public static void PrintArray(int[] array) {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}
