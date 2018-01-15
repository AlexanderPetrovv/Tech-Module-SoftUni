using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)        // Constructor
        {
            X = x;
            Y = y;
        }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }

        public override string ToString()
        {
            return "Car " + Brand + " " + Model + " " + MaxSpeed + "km/h";
        }
    }

    class DistanceBetweenPoints
    {
        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
        }

        static void Main(string[] args)
        {
            // Defining Simple Classes

            //Point p = new Point();
            //p.X = 5;
            //p.Y = -10;
            //Console.WriteLine(p.X + " " + p.Y);

            Car myCar = new Car()
            {
                Brand = "Mercedes",
                Model = "Benz",
                MaxSpeed = 320
            };
            Console.WriteLine(myCar);

            var students = new Student[]
            {
                new Student() { Name = "Pesho", Age = 26 },
                new Student() { Name = "Maria", Age = 15, Email = "mary@abv.bg" },
                new Student() { Name = "Kiro", Age = 18 }
            };
            List<string> studentsForPrint = students.OrderBy(s => s.Age).Select(s => s.Name + " " + s.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, studentsForPrint));

            Point a = new Point(5, 7);
            Console.WriteLine("({0}, {1})", a.X, a.Y);

            var myGame = new ClassesDemo.Game
            {
                Name = "World of Warcraft",
                Price = 49.99m,
                HDDSize = 40.5
            };

            Console.WriteLine("Game: {0}\r\nPrice: {1}\r\nSize on HDD: {2}", myGame.Name, myGame.Price, myGame.HDDSize);
        }
    }
}
