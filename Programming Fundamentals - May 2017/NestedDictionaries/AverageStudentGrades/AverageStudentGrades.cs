using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] token = Console.ReadLine().Split(' ');
                string name = token[0];
                double grade = double.Parse(token[1]);

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades[name] = new List<double>();
                }
                studentGrades[name].Add(grade);
            }

            foreach (var student in studentGrades)
            {
                string name = student.Key;
                List<double> grades = student.Value;
                double average = grades.Average();
                Console.Write($"{name} -> ");
                foreach (double grade in grades)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {average:F2})");
            }
        }
    }
}
