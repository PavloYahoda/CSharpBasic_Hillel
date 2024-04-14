using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_equation
{
    class Program
    {
        private static double descr;
        private static int countOfRoots;
        private static int[] coefficients;
        static void Main(string[] args)
        {
            coefficients = GenerateRandomNumbers();

            Console.WriteLine(PrintEquation(coefficients));

            countOfRoots = CountOfRoots(coefficients);
            Console.WriteLine($"Count of routs is {countOfRoots}");

            Console.WriteLine(СalculationOfRoots(coefficients, countOfRoots, descr));
            Console.ReadKey();
        }
        public static int[] GenerateRandomNumbers() {
            int[] numbers = new int[3];
            
            Random random = new Random();
            for (int i = 0; i < 3; i++) {
                numbers[i] = random.Next(-100, 101); ;
            }
            return numbers;
        }

        public static string PrintEquation(int[] abc) {
            string coefA = $"{abc[0]}";
            string coefB = abc[1] >= 0 ? $"+{abc[1]}" : $"{abc[1]}";
            string coefC = abc[2] >= 0 ? $"+{abc[2]}" : $"{abc[2]}";
            string str = String.Format("Quadric equation is: {0}x^2{1}x{2} = 0 ", coefA, coefB, coefC);
            return str;
        }
        public static int CountOfRoots(int[] abc) {
            int count;
            int a = abc[0];
            int b = abc[1];
            int c = abc[2];
            double D = Math.Pow(b, 2) - 4 * a * c;

            descr = D;

            if (D == 0)
            {
                count = 1;
            }
            else if (D > 0)
            {
                count = 2;
            }
            else {
                count = 0;            
            }
            return count;
        }

        public static string СalculationOfRoots(int[] abc, int countOfRoots, double descr) {
            string rootsOfEquation;
            double root1;
            double root2;
            int a = abc[0];
            int b = abc[1];
            if (a == 0)
            {
                rootsOfEquation = "Equation is liner";
            }
            else if (countOfRoots == 2)
            {
                root1 = -b + Math.Sqrt(descr) / (2 * a);
                root2 = -b - Math.Sqrt(descr) / (2 * a);
                rootsOfEquation = $"Root X1 = {root1:F3}, root X2 = {root2:F3}";
            }
            else if (countOfRoots == 1)
            {
                root1 = -b / (2 * a);
                rootsOfEquation = $"Root X1 and root X2 = {root1:F3}";
            }
            else {
                rootsOfEquation = "There are no roots";
            }

            return rootsOfEquation;
        }
    }
}
