using System;
using System.Linq;
using System.Reflection;

namespace ExercisesConditionals
{
    class Program
    {
        public static ProgramMenu ThisMenu = new ProgramMenu();

        static void Main()
        {

            // Set program title and menu list.
            ThisMenu.Title = "\nExercises - Conditionals:\n\nChoose from the following:\n";
            ThisMenu.Exercises.Add("1", "Number between 1 and 10");
            ThisMenu.Exercises.Add("2", "Maximum of two numbers");
            ThisMenu.Exercises.Add("3", "Orientation of an image");
            ThisMenu.Exercises.Add("4", "Speed camera");
            ThisMenu.Exercises.Add("x", "Exit program");
            ThisMenu.DisplayMenu();

            // Main Program Loop.
            while (true)
            {
                var choice = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (ThisMenu.Exercises.ContainsKey(choice))
                {
                    var methodName = "Exercise" + choice.ToUpper();
                    Type type = typeof(Program);
                    MethodInfo methodToCall = type.GetMethod(methodName);
                    if (methodToCall != null) methodToCall.Invoke(methodName, null);
                }
            }
        }

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

        public static void Exercise1()
        {
            Console.Clear();

            var runAgain = true;
            while (runAgain)
            {
                Console.WriteLine("Exercise 1: Number between 1 and 10\n");
                Console.Write("Please enter a number between 1 and 10 => ");
                var left = Console.CursorLeft;
                var top = Console.CursorTop;
                var input = Console.ReadLine();
                if (int.TryParse(input, out var value) && value > 0 && value < 11)
                {
                    Console.SetCursorPosition(left + input.Length, top);
                    Console.WriteLine(" = Valid");
                }
                else
                {
                    Console.SetCursorPosition(left + input.Length, top);
                    Console.WriteLine(" = Invalid");
                }
                runAgain = RunAgain();
            }
            ThisMenu.DisplayMenu();
        }

        public static void Exercise2()
        {
            Console.Clear();
            var runAgain = true;
            while (runAgain)
            {
                Console.WriteLine("Exercise 2: Maximum of two numbers\n");
                var userNumbers = new int[2];
                var number = 0;
                bool validChoice = false;
                while (number < 2)
                {
                    while (!validChoice)
                    {
                        var text = number == 0 ? "first" : "second";
                        Console.Write($"Please enter your {text} number => ");
                        var left = Console.CursorLeft;
                        var top = Console.CursorTop;
                        var input = Console.ReadLine();
                        if (int.TryParse(input, out var value))
                        {
                            userNumbers[number] = value;
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

                Console.WriteLine($"The maximum number is: {userNumbers.Max()}");

                runAgain = RunAgain();
            }
            ThisMenu.DisplayMenu();
        }

        public static void Exercise3()
        {
            Console.Clear();
            var runAgain = true;
            while (runAgain)
            {
                Console.WriteLine("Exercise 3: Orientation of an image\n");
                string text;
                var userNumbers = new int[2];
                var number = 0;
                bool validChoice = false;
                while (number < 2)
                {
                    while (!validChoice)
                    {
                        text = number == 0 ? "width" : "height";
                        Console.Write($"Please enter the {text} of the image => ");
                        var left = Console.CursorLeft;
                        var top = Console.CursorTop;
                        var input = Console.ReadLine();
                        if (int.TryParse(input, out var value))
                        {
                            userNumbers[number] = value;
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

                text = userNumbers[0] > userNumbers[1] ? "landscape" : "portrait";
                if (userNumbers[0] == userNumbers[1]) text = "square";
                Console.WriteLine($"The image is: {text}");

                runAgain = RunAgain();
            }
            ThisMenu.DisplayMenu();
        }

        public static void Exercise4()
        {
            Console.Clear();
            var runAgain = true;
            while (runAgain)
            {
                Console.WriteLine("Exercise 4: Speed Camera\n");
                string text;
                var userNumbers = new int[2];
                var number = 0;
                bool validChoice = false;
                while (number < 2)
                {
                    while (!validChoice)
                    {
                        text = number == 0 ? "speed limit" : "speed of the car";
                        Console.Write($"Please enter the {text} => ");
                        var left = Console.CursorLeft;
                        var top = Console.CursorTop;
                        var input = Console.ReadLine();
                        if (int.TryParse(input, out var value))
                        {
                            userNumbers[number] = value;
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

                int demeritPoints = Math.Max(0, userNumbers[1] - userNumbers[0] + 4) / 5;

                text = userNumbers[0] >= userNumbers[1] ? "OK" : demeritPoints + " demerit points";
                text += demeritPoints > 12 ? " - license suspended" : "";
                Console.WriteLine($"Speed camera result: {text}");

                runAgain = RunAgain();
            }
            ThisMenu.DisplayMenu();
        }

        public static void ExerciseX()
        {
            Console.Write("\nThank you for using this program. ");
            Environment.Exit(0);
        }

    }

}