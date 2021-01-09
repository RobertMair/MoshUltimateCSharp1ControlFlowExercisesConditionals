using System;
using System.Collections.Generic;

namespace ExercisesConditionals
{
    public class ProgramMenu
    {
        public string Title { get; set; }

        public Dictionary<string, string> Exercises = new Dictionary<string, string>();

        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine(Title);
            foreach (var exercise in Exercises)
            {
                Console.WriteLine(exercise.Key + ". " + exercise.Value);
            }
        }

    }
}