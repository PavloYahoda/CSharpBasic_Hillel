using System;


namespace Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] allMarks = InitializeData();
            //PrintArray(allMarks);
            string math = "Math";
            string history = "History";
            string language = "Language";


            while (true)
            {
                Console.Write("1.Enter marks of Math\n" +
                    "2.Enter marks of History\n" +
                    "3.Enter marks of Language\n" +
                    "4.Show all marks\n" +
                    "5.Exit\n" +
                    "Choose an option:");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Output(allMarks[0], math);
                        break;
                    case "2":
                        Output(allMarks[1], history);
                        break;
                    case "3":
                        Output(allMarks[2], language);
                        break;
                    case "4":
                        ShortOutput(allMarks[0], math);
                        ShortOutput(allMarks[1], history);
                        ShortOutput(allMarks[2], language);
                       
                        break;
                    case "5":
                        Console.WriteLine("Exiting program");
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
        public static int[][] InitializeData()
        {
            int[] marksMath = new int[10];
            int[] marksHistory = new int[10];
            int[] marksLanguage = new int[10];
            int[][] marks = new int[3][];
            marks[0] = marksMath;
            marks[1] = marksHistory;
            marks[2] = marksLanguage;
            int countOfSetMarks = 4;
            Random random = new Random();
            for (int i = 0; i < marks.Length; i++)
            {
                for (int j = 0; j < countOfSetMarks; j++)
                {
                    marks[i][j] = random.Next(1, 13);
                }
            }
            return marks;
        }
        
        public static void SetMark(int[] array, int index, int value)
        {
            array[index] = value;
        }
        public static int[] SetMarks(int[] array)

        {
            int user_input;
            while (true)
            {
                try
                {
                    user_input = Convert.ToInt32(Console.ReadLine());
                    if (user_input == 0)
                    {
                        break;
                    }
                    else
                    {
                       if (array[array.Length - 1] != 0)
                       {
                            Array.Resize(ref array, array.Length + 10);
                            SetMark(array, Array.IndexOf(array, 0), user_input);
                        }
                        else
                        {
                            SetMark(array, Array.IndexOf(array, 0), user_input);
                        }  
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Processing failed: {ex.Message}");
                }
            }
            int[] changedArray = new int[array.Length];
            Array.Copy(array, changedArray, array.Length);
            return changedArray;
        }
        public static double CalcAverage(int[] array) {  
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] != 0) {
                    sum += array[i];
                    count++;
                }
            }
            double avg = sum/count;
            return avg;
        }
        public static void PrintArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void PrintArray(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
        public static void Output(int[] array, string subject) {
            Console.WriteLine($"You can enter other marks of {subject}. For exit enter 0");
            array = SetMarks(array);
            Console.Write($"Current marks of {subject} are: ");
            PrintArray(array);

            double avg = CalcAverage(array);
            Console.WriteLine($"Average is: {avg:F2}");
        }
        public static void ShortOutput(int[] array, string subject) {
            Console.Write($"Current marks of {subject} are: ");
            PrintArray(array);
            double avg = CalcAverage(array);
            Console.WriteLine($"Average is: {avg:F2}");
        }
    }
}
