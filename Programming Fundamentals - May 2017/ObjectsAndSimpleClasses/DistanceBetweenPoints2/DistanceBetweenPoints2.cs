using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints2
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)         // Constructor
        {
            X = x;
            Y = y;
        }

        public static Point Parse(string input)           // Our own static Point.Parse method
        {
            int[] inputArr = input.Split(' ').Select(int.Parse).ToArray();
            int x = inputArr[0];
            int y = inputArr[1];
            return new Point(x, y);
        }
    }

    class DistanceBetweenPoints2
    {
        static void Main(string[] args)
        {
            Point firstPoint = Point.Parse(Console.ReadLine());
            Point secondPoint = Point.Parse(Console.ReadLine());

            double distance = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine($"{distance:F3}");
        }

        static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = Math.Pow(firstPoint.X - secondPoint.X, 2);
            double sideB = Math.Pow(firstPoint.Y - secondPoint.Y, 2);
            return Math.Sqrt(sideA + sideB);
        }
    }
}
