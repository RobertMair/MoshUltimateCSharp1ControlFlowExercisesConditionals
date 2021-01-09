using System;
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
                    Type type = typeof(ProgramExercises);
                    MethodInfo methodToCall = type.GetMethod(methodName);
                    if (methodToCall != null) methodToCall.Invoke(methodName, null);
                }
            }
        }
    }

}