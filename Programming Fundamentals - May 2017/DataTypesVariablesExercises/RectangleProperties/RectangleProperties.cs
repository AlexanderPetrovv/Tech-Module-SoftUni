using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            double rectWidth = double.Parse(Console.ReadLine());
            double rectHeight = double.Parse(Console.ReadLine());

            double rectPerimeter = (rectWidth + rectHeight) * 2.0;
            double rectArea = rectWidth * rectHeight;
            double rectDiagonal = Math.Sqrt(rectWidth * rectWidth + rectHeight * rectHeight);

            Console.WriteLine(rectPerimeter);
            Console.WriteLine(rectArea);
            Console.WriteLine(rectDiagonal);
        }
    }
}
