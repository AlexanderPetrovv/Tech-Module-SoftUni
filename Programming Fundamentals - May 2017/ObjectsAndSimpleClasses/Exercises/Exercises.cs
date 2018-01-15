using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }
    }

    class Exercises
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<Exercise> exercises = new List<Exercise>();

            while (line != "go go go")
            {
                string[] tokens = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string topic = tokens[0];
                string courseName = tokens[1];
                string judgeContestLink = tokens[2];
                string[] problems = tokens[3].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                exercises.Add(new Exercise
                {
                    Topic = topic,
                    CourseName = courseName,
                    JudgeContestLink = judgeContestLink,
                    Problems = new List<string>(problems)
                });

                line = Console.ReadLine();
            }

            PrintExercises(exercises);
        }

        static void PrintExercises(List<Exercise> exercises)
        {
            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                List<string> problems = exercise.Problems;
                int cnt = 1;
                foreach (var problem in problems)
                {
                    Console.WriteLine($"{cnt}. {problem}");
                    cnt++;
                }
            }
        }
    }
}
