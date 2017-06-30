using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program that can calculate the area of four different geometry figures - triangle, square, rectangle and circle. 
*/

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            CalcAreaOfGivenFigure(figure);
        }

        static void CalcAreaOfGivenFigure(string figure)
        {
            switch (figure)
            {
                case "triangle":
                    CalcTriangleArea();
                    break;
                case "square":
                    CalcSquareArea();                  
                    break;
                case "rectangle":
                    CalcRectangleArea();                   
                    break;
                case "circle":
                    CalcCircleArea();                 
                    break;
            }
        }

        static void CalcCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"{area:f2}");
        }

        static void CalcRectangleArea()
        {
            double rectWidth = double.Parse(Console.ReadLine());
            double rectHeight = double.Parse(Console.ReadLine());
            double area = rectHeight * rectWidth;
            Console.WriteLine($"{area:f2}");
        }

        static void CalcSquareArea()
        {
            double squareSide = double.Parse(Console.ReadLine());
            double area = squareSide * squareSide;
            Console.WriteLine($"{area:f2}");
        }

        static void CalcTriangleArea()
        {
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double area = triangleHeight * triangleSide / 2.0;
            Console.WriteLine($"{area:f2}");
        }
    }
}
