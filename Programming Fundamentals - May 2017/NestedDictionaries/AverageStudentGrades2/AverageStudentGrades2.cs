using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentGrades2
{
    class AverageStudentGrades2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] studentData = Console.ReadLine().Split(' ');
                string name = studentData[0];
                double grade = double.Parse(studentData[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }

            // Absolutely barberic way of printing the output
            foreach (var studentGrades in grades)
            {
                List<string> gradesList = new List<string>();
                double sumGrades = 0;
                int gradesCount = 0;
                foreach (var grade in studentGrades.Value)
                {
                    var decimalPart = "" + Math.Round(grade * 100) % 100;
                    if (decimalPart.Length < 2)
                    {
                        decimalPart = "0" + decimalPart;
                    }
                    var gradeStr = Math.Truncate(grade) + "." + decimalPart;
                    gradesList.Add(gradeStr);
                    gradesCount++;
                    sumGrades += grade;

                    //gradesList.Add(String.Format("{0:f2}", grade))
                }

                Console.WriteLine("{0} -> {1} (avg: {2:f2})",
                    studentGrades.Key,
                    string.Join(" ", gradesList),
                    sumGrades / gradesCount);

                //Console.WriteLine("{0} -> {1} (avg: {2})",
                //    studentGrades.Key,
                //    string.Join(" ", studentGrades.Value.Select(x => string.Format("{0:f2}", x))),
                //    studentGrades.Value.Average());
            }
        }
    }
}
