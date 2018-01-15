using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        //public IEnumerable<double> Grades { get; set; }
        public List<double> Grades { get; set; }
        //public double AverageGrade => this.Grades.Average();
        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }

        public Student(string name, List<double> grades)
        {
            this.Name = name;
            this.Grades = grades;
        }
    }

    class AverageGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string studentName = tokens[0];
                List<double> grades = tokens.Skip(1).Select(double.Parse).ToList();
                Student student = new Student(studentName, grades);
                students.Add(student);
            }

            List<Student> filteredStudents = students
                .Where(s => s.AverageGrade >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }
    }
}
