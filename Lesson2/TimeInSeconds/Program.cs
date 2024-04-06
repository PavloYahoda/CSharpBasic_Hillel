using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TimeInSeconds
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Enter time in format HH:MM:SS ");
            string userInput = Console.ReadLine();
            bool isStringCorrect = Regex.Match(userInput, @"^([0-9]|0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$").Success;
            if (isStringCorrect){
                Console.WriteLine(isStringCorrect);
                string[] time = userInput.Split(':');
                int hours = Convert.ToInt32(time[0]);
                int minutes = Convert.ToInt32(time[1]);
                int seconds = Convert.ToInt32(time[2]);               
                int timeInSeconds = hours * 360 + minutes * 60 + seconds;
                Console.WriteLine($"Time in seconds is {timeInSeconds}");
                Console.ReadKey();
            } else {
                Console.WriteLine("Time format is wrong");
            }
            Console.ReadKey();
        }
    }
}
