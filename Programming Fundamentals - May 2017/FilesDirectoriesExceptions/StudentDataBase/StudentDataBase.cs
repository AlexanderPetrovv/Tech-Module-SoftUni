using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataBase
{
    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<double> Grades { get; set; }
    }

    class StudentDataBase
    {
        static void Main(string[] args)
        {
            //if (!Directory.Exists("Students"))
            //{
            //    Directory.CreateDirectory("Students");
            //}

            //if (!File.Exists(@"Students\database.schoolfile"))
            //{
            //    File.Create(@"Students\database.schoolfile");
            //}

            Dictionary<string, Student> studentsByName = new Dictionary<string, Student>();

            // LOAD ALL PREVIOUS DATA
            string[] storedStudents = File.ReadAllLines(@"Students\database.schoolfile");

            foreach (var studentInfo in storedStudents)
            {
                string[] studentTokens = studentInfo.Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries);
                // name | age | grade1, grade2, grade3...

                Student newStudent = new Student();

                newStudent.Name = studentTokens[0];
                newStudent.Age = int.Parse(studentTokens[1]);
                newStudent.Grades = studentTokens.Skip(2).Select(double.Parse).ToList();

                studentsByName.Add(newStudent.Name, newStudent);
            }

            string inputLine = Console.ReadLine();
            // {student} -> {age} -> {grades}   // ONLY IF IT DOES NOT EXIST, ELSE PRINT THAT USER ALREADY EXISTS
            // {student} -> {grade} // PRINT USER DOES NOT EXIST

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length >= 3)
                {
                    // REGISTER STUDENT LOGIC
                    try
                    {
                        Student newStudent = new Student();
                        newStudent.Name = tokens[0];
                        newStudent.Age = int.Parse(tokens[1]);
                        newStudent.Grades = tokens.Skip(2).Select(double.Parse).ToList();

                        studentsByName.Add(newStudent.Name, newStudent);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("Failed to register student. Student already exists.");
                    }
                }
                else
                {
                    // ADD GRADE LOGIC
                    try
                    {
                        string studentName = tokens[0];
                        studentsByName[studentName].Grades.AddRange(tokens.Skip(1).Select(double.Parse).ToList());
                    }
                    catch (KeyNotFoundException e)
                    {
                        Console.WriteLine("Failed to access student. Student does not exist.");
                    }
                }

                inputLine = Console.ReadLine();
            }

            File.WriteAllLines(@"Students\database.schoolfile",
                studentsByName.OrderBy(s => s.Key)
                .Select(s => s.Value)
                .Select(s => string.Format("{0} | {1} | {2:F2}", s.Name, s.Age, string.Join(", ", s.Grades))));
        }
    }
}
