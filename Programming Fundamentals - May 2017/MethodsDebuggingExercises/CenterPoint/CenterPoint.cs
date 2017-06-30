using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2 and Y2.
Create a method that prints the point that is closest to the center of the coordinate system (0, 0) in the format (X, Y).
If the points are on a same distance from the center, print only the first one.
*/

namespace CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (PointIsCloserToCenter(x1, y1, x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})"); 
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static bool PointIsCloserToCenter(double x1, double y1, double x2, double y2)
        {
            double distance1 = CalcDistanceBetweenPoints(x1, y1, 0, 0);
            double distance2 = CalcDistanceBetweenPoints(x2, y2, 0, 0);

            if (distance1 < distance2)
            {
                return true;
            }
            return false;
        }

        static double CalcDistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }
    }
}
