using System;
using System.Collections.Generic;
using System.Linq;

namespace JsonParse
{
    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<int> Grades { get; set; }

        public Student(string name, int age, List<int> grades)
        {
            Name = name;
            Age = age;
            Grades = new List<int>(grades);
        }

        public override string ToString()
        {
            return Grades.Count != 0 ? $"{Name} : {Age} -> {string.Join(", ", Grades)}" : $"{Name} : {Age} -> None";
        }
    }

    class JsonParse
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string line = Console.ReadLine();
            line = line.Substring(2, line.Length - 4);
            var tokens = line.Split(new string[] { "},{" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                string[] studentTokens = token.Split(new string[] { "name:\"", "\",age:", ",grades:" }, StringSplitOptions.RemoveEmptyEntries);
                string name = studentTokens[0];
                int age = int.Parse(studentTokens[1]);
                var grades = studentTokens[2]
                    .Substring(1, studentTokens[2].Length - 2)
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                Student student = new Student(name, age, grades);
                students.Add(student);
            }

            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
    }
}
