using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            // Problem: Circle area with 12 digits precision
            double radius = double.Parse(Console.ReadLine());
            double circleArea = radius * radius * Math.PI;
            Console.WriteLine($"{circleArea:F12}");
        }
    }
}
