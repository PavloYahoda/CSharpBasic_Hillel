﻿using System;
using System.Text.RegularExpressions;

namespace Contacts
{
    public static class Helper
    {
        public static int ReadChoice()
        {
            string userChoice;
            while (true)
            {
                userChoice = Console.ReadLine();
                bool isChoiceCorrect = Regex.Match(userChoice, @"^[0-5]$").Success;
                if (isChoiceCorrect == false)
                {
                    ClearLastLine();
                    Console.Write("You make wrong choice. Try again: ");
                }
                else return Convert.ToInt32(userChoice);
            }
        }
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            //Console.WriteLine();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}
