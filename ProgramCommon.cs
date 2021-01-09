using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesConditionals
{
    class ProgramCommon
    {
        public static bool RunAgain()
        {
            Console.Write("\nPress 'r' to run again or 'm' to return to menu => ");
            while (true)
            {
                var choice = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (choice == "r")
                {
                    Console.WriteLine("r\n");
                    return true;
                }
                if (choice == "m")
                {
                    return false;
                }
            }
        }

        public static List<int> GetNumbers(List<string> text, int min, int max)
        {
            var number = 0;
            var userNumbers = new List<int>();
            bool validChoice = false;
            while (number < text.Count())
            {
                while (!validChoice)
                {
                    Console.Write($"Please enter the {text[number]} => ");
                    var left = Console.CursorLeft;
                    var top = Console.CursorTop;
                    var input = Console.ReadLine();
                    if (int.TryParse(input, out var value) && value >= min && value <= max)
                    {
                        userNumbers.Add(value);
                        validChoice = true;
                    }
                    else
                    {
                        Console.SetCursorPosition(left + input.Length, top);
                        Console.WriteLine(" = Invalid");
                    }
                }
                number++;
                validChoice = false;
            }
            return userNumbers;
        }
    }
}