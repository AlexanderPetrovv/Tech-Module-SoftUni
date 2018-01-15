using System;
using System.Collections.Generic;
using System.Linq;

namespace JsonStringify
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
            return $"{{name:\"{Name}\",age:{Age},grades:[{string.Join(", ", Grades)}]}}";
        }
    }

    class JsonStringify
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string line = Console.ReadLine();

            while (line != "stringify")
            {
                string[] inputTokens = line.Split(new[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0].Trim();
                int age = int.Parse(inputTokens[1]);
                List<int> grades = inputTokens.Skip(2).Select(int.Parse).ToList();

                Student student = new Student(name, age, grades);
                students.Add(student);

                line = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(",", students)}]");
        }
    }
}
