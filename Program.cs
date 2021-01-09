using System;
using System.Collections.Generic;
using System.Reflection;

namespace ExercisesConditionals
{
    class Program
    {
        static void Main()
        {
            var exercises = new Dictionary<int, string>
            {
                {1, "Number between 1 and 10"},
                {2, "Maximum of two numbers"},
                {3, "Orientation of an image"},
                {4, "Speed camera"}
            };

            Console.WriteLine("\nExercises - Conditionals:\n\nChoose from the following:\n");

            foreach (var exercise in exercises)
            {
                Console.WriteLine(exercise.Key + ". " + exercise.Value);
            }

            while (true)
            {
                var choice = Console.ReadKey(true);
                int value;
                if (int.TryParse(choice.KeyChar.ToString(), out value) && exercises.ContainsKey(value))
                {
                    var methodName = "Exercise" + value;
                    Type type = typeof(Program);
                    MethodInfo methodToCall = type.GetMethod(methodName);
                    if (methodToCall != null) methodToCall.Invoke(methodName, null);
                }
            }

        }

        public static void Exercise1()
        {
            Console.WriteLine("Number between 1 and 10");
        }

        public static void Exercise2()
        {
            Console.WriteLine("Maximum of two numbers");
        }

        public static void Exercise3()
        {
            Console.WriteLine("Orientation of an image");
        }

        public static void Exercise4()
        {
            Console.WriteLine("Speed camera");
        }
    }

}
