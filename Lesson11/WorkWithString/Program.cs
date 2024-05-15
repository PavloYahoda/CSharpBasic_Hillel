using System;
using UkrainianStringUtilsLib;

namespace WorkWithString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Введіть будь-яке речення: ");
            string input = Console.ReadLine();

            Console.WriteLine($"Кількість голосних у реченні: {UkrainianStringUtils.CountVowels(input)}");
            Console.WriteLine($"Кількість приголосних у реченні: {UkrainianStringUtils.CountConsonants(input)}");
            Console.WriteLine($"Речення навпаки: {UkrainianStringUtils.ReverseString(input)}");
            Console.WriteLine($"Без дублікатів: {UkrainianStringUtils.RemoveDuplicates(input)}");
            Console.WriteLine($"Без пунктуації: {UkrainianStringUtils.RemovePunctuation(input)}");

            Console.ReadKey();
        }
    }
}
