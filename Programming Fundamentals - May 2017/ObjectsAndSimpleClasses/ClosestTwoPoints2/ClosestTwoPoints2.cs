using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints2
{
    class ClosestTwoPoints2
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            //public Point(int x, int y)
            //{
            //    X = x;
            //    Y = y;
            //}

            public static Point Parse(string input)
            {
                int[] inputInfo = input.Split(' ').Select(int.Parse).ToArray();
                return new Point() { X = inputInfo[0], Y = inputInfo[1] };
            }

            public override string ToString()
            {
                return String.Format($"({X}, {Y})");
            }
        }

        static void Main(string[] args)
        {
            List<Point> points = ReadPoints();
            List<Point> closestTwoPoints = FindClosestTwoPoints(points);

            PrintMinDistance(closestTwoPoints);
            //PrintPoint(closestTwoPoints[0]);
            //PrintPoint(closestTwoPoints[1]);

            Console.WriteLine(closestTwoPoints[0]);
            Console.WriteLine(closestTwoPoints[1]);
        }

        static List<Point> ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPoint = Point.Parse(Console.ReadLine());
                points.Add(currentPoint);
            }
            return points;
        }

        static List<Point> FindClosestTwoPoints(List<Point> points)
        {
            double minDistance = double.MaxValue;
            List<Point> closestTwoPoints = null;

            for (int p1 = 0; p1 < points.Count - 1; p1++)
            {
                for (int p2 = p1 + 1; p2 < points.Count; p2++)
                {
                    double distance = CalcDistance(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new List<Point>() { points[p1], points[p2] };
                    }
                }
            }
            return closestTwoPoints;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p1.X - p2.X;
            int deltaY = p1.Y - p2.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        static void PrintMinDistance(List<Point> points)
        {
            double distance = CalcDistance(points[0], points[1]);
            Console.WriteLine($"{distance:F3}");
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }
    }
}
