using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            int deltaX = p1.X - p2.X;
            int deltaY = p1.Y - p2.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    class Box
    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }

        public Box(Point upperLeft, Point upperRight, Point bottomLeft, Point bottomRight)
        {
            this.UpperLeft = upperLeft;
            this.UpperRight = upperRight;
            this.BottomLeft = bottomLeft;
            this.BottomRight = bottomRight;
        }

        public int Width
        {
            get
            {
                return (int)Point.CalculateDistance(UpperLeft, UpperRight);
            }
        }

        public int Height
        {
            get
            {
                return (int)Point.CalculateDistance(UpperLeft, BottomLeft);
            }
        }

        public static int CalculatePerimeter(int width, int height)
        {
            return 2 * width + 2 * height;
        }

        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }

    class Boxes
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] pointsData = line.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                List<Point> points = new List<Point>();

                foreach (var pointData in pointsData)
                {
                    int[] pointCoordinates = pointData.Split(':').Select(int.Parse).ToArray();
                    int x = pointCoordinates[0];
                    int y = pointCoordinates[1];

                    points.Add(new Point(x, y));
                }

                Point upperLeft = points[0];
                Point upperRight = points[1];
                Point bottomLeft = points[2];
                Point bottomRight = points[3];

                Box currentBox = new Box(upperLeft, upperRight, bottomLeft, bottomRight);

                Console.WriteLine("Box: {0}, {1}", currentBox.Width, currentBox.Height);
                Console.WriteLine("Perimeter: {0}", Box.CalculatePerimeter(currentBox.Width, currentBox.Height));
                Console.WriteLine("Area: {0}", Box.CalculateArea(currentBox.Width, currentBox.Height));

                line = Console.ReadLine();
            }
        }
    }
}
