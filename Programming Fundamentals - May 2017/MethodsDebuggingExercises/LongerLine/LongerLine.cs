using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You are given the coordinates of four points in the 2D plane.
The first and the second pair of points form two different lines.
Print the longer line in format "(X1, Y1)(X2, Y2)"
starting with the point that is closer to the center of the coordinate system (0, 0).
If the lines are of equal length, print only the first one.
*/

namespace LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLine = CalcDistanceBetweenPoints(x1, y1, x2, y2);
            double secondLine = CalcDistanceBetweenPoints(x3, y3, x4, y4);

            if (firstLine >= secondLine)
            {
                PrintCloserLine(x1, y1, x2, y2);
            }
            else
            {
                PrintCloserLine(x3, y3, x4, y4);
            }
        }
        
        static void PrintCloserLine(double x1, double y1, double x2, double y2)
        {
            if (PointIsCloserToCenter(x1, y1, x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }

        static double CalcDistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }

        static bool PointIsCloserToCenter(double x1, double y1, double x2, double y2)
        {
            double distance1 = CalcDistanceBetweenPoints(x1, y1, 0, 0);
            double distance2 = CalcDistanceBetweenPoints(x2, y2, 0, 0);

            if (distance1 <= distance2)
            {
                return true;
            }
            return false;
        }
    }
}
