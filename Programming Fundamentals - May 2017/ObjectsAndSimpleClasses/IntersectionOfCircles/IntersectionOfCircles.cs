using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfCircles
{
    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public static bool Intersect(Circle first, Circle second)
        {
            double centersDistance = Point.CalcDistance(first.Center, second.Center);
            return centersDistance <= first.Radius + second.Radius;
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            double deltaX = p2.X - p1.X;
            double deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    class IntersectionOfCircles
    {
        static void Main(string[] args)
        {
            Circle firstCircle = ReadCircle();
            Circle secondCircle = ReadCircle();

            if(Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static Circle ReadCircle()
        {
            double[] circleInfo = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double x = circleInfo[0];
            double y = circleInfo[1];
            double radius = circleInfo[2];
            Point center = new Point(x, y);

            return new Circle { Center = center, Radius = radius };
        }
    }
}
