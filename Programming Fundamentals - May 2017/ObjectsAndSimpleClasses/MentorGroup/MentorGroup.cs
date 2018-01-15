using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MentorGroup
{
    class Student
    {
        public List<string> Comments { get; set; }
        public List<string> AttendanceDates { get; set; }
        public string Name { get; set; }
    }

    class MentorGroup
    {
        static void Main(string[] args)
        {           
            string inputLine = Console.ReadLine();
            List<Student> members = new List<Student>();

            while (!inputLine.Equals("end of dates"))
            {
                string[] tokens = inputLine.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string user = tokens[0];
                List<string> dates = new List<string>();
                if (tokens.Length > 1)
                {
                    dates = tokens.Skip(1).ToList();
                }

                if (members.Any(s => s.Name == user))
                {
                    Student student = members.First(s => s.Name == user);
                    student.AttendanceDates.AddRange(dates);
                }
                else
                {
                    Student student = new Student();
                    student.Name = user;
                    student.AttendanceDates = new List<string>();
                    student.AttendanceDates.AddRange(dates);

                    members.Add(student);
                }
                
                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            while (!inputLine.Equals("end of comments"))
            {
                string[] tokens = inputLine.Split('-');
                string name = tokens[0];                

                if (members.Any(s => s.Name == name))
                {
                    Student student = members.First(s => s.Name == name);                  
                    if (tokens.Length > 1)
                    {
                        string comment = tokens[1];
                        if (student.Comments == null)
                        {
                            student.Comments = new List<string>();                           
                            student.Comments.Add(comment);
                        }
                        else
                        {
                            student.Comments.Add(comment);
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }
            
            foreach (Student student in members.OrderBy(s => s.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                if (student.Comments != null)
                {
                    foreach (string comment in student.Comments)
                    {
                        Console.WriteLine("- {0}", comment);
                    }
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in student.AttendanceDates.OrderBy(d => d))
                {
                    Console.WriteLine("-- {0}", date);
                }
            }
        }
    }
}
