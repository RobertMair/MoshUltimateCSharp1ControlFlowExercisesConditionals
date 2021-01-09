using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesConditionals
{
    class ProgramExercises
    {

        public static void Exercise1()
        {
            Console.Clear();

            var runAgain = true;
            while (runAgain)
            {
                Console.WriteLine("Exercise 1: Number between 1 and 10\n");

                var inputText = new List<string>
                {
                    "number of your choice between 1 and 10"
                };

                var userNumbers = ProgramCommon.GetNumbers(inputText, 1, 10);

                Console.WriteLine($"The number {userNumbers[0]} is Valid");

                runAgain = ProgramCommon.RunAgain();
            }

            Program.ThisMenu.DisplayMenu();
        }

        public static void Exercise2()
        {
            Console.Clear();
            var runAgain = true;
            while (runAgain)
            {
                Console.WriteLine("Exercise 2: Maximum of two numbers\n");

                var inputText = new List<string>
                {
                    "first number",
                    "second number"
                };

                var userNumbers = ProgramCommon.GetNumbers(inputText, -2147483648, 2147483647);

                Console.WriteLine($"The maximum number is: {userNumbers.Max()}");

                runAgain = ProgramCommon.RunAgain();

            }

            Program.ThisMenu.DisplayMenu();
        }

        public static void Exercise3()
        {
            Console.Clear();
            var runAgain = true;
            while (runAgain)
            {
                Console.WriteLine("Exercise 3: Orientation of an image\n");

                var inputText = new List<string>
                {
                    "image width",
                    "image height"
                };

                var userNumbers = ProgramCommon.GetNumbers(inputText, 1, 2147483647);

                var resultText = userNumbers[0] > userNumbers[1] ? "landscape" : "portrait";
                if (userNumbers[0] == userNumbers[1]) resultText = "square";
                Console.WriteLine($"The image is: {resultText}");

                runAgain = ProgramCommon.RunAgain();

            }

            Program.ThisMenu.DisplayMenu();
        }

        public static void Exercise4()
        {
            Console.Clear();
            var runAgain = true;
            while (runAgain)
            {
                Console.WriteLine("Exercise 4: Speed Camera\n");

                var inputText = new List<string>
                {
                    "speed limit",
                    "speed of the car"
                };

                var userNumbers = ProgramCommon.GetNumbers(inputText, 0, 2147483647);

                int demeritPoints = Math.Max(0, userNumbers[1] - userNumbers[0] + 4) / 5;
                var text = userNumbers[0] >= userNumbers[1] ? "OK" : demeritPoints + " demerit points";
                text += demeritPoints > 12 ? " - license suspended" : "";
                Console.WriteLine($"Speed camera result: {text}");

                runAgain = ProgramCommon.RunAgain();

            }

            Program.ThisMenu.DisplayMenu();
        }

        public static void ExerciseX()
        {
            Console.Write("\nThank you for using this program. ");
            Environment.Exit(0);
        }
    }
}