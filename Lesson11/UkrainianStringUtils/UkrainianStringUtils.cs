using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace UkrainianStringUtilsLib
{
    public static class UkrainianStringUtils
    {
        public static int CountVowels(string input)
        {
            string allVowels = "аеєиіїоуюяAEЄИIЇОУЮЯ";

            int count = 0;
            foreach (char ch in input)
            {
                if (allVowels.Contains(ch))
                {
                    count++;
                }
            }
            return count;
        }
        public static int CountConsonants(string input)
        {
            // Стрінг з приголосними літерами
            string allConsonants = "бвгґджзклмнпрстфхцчшщБВГҐДЖЗКЛМНПРСТФХЦЧШЩ";

            int count = 0;
            foreach (char ch in input)
            {
                if (allConsonants.Contains(ch))
                {
                    count++;
                }
            }
            return count;
        }
        public static string ReverseString(string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
        public static string RemoveDuplicates(string input)
        {
            return new string(input.Distinct().ToArray());
        }
        public static string RemovePunctuation(string input)
        {
            return Regex.Replace(input, @"[\p{P}\p{S}\s]", "");
        }
    }
}
