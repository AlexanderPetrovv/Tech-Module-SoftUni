using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class RectanglePosition
    {
        class Rectangle
        {
            public double Top { get; set; }
            public double Left { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }

            public double Bottom
            {
                get
                {
                    return Top + Height;
                }
            }

            public double Right
            {
                get
                {
                    return Left + Width;
                }
            }

            public double CalcArea()
            {
                return Width * Height;
            }

            public bool IsInside(Rectangle other)
            {
                bool leftIsValid = Left >= other.Left;
                bool topIsValid = Top >= other.Top;
                bool rightIsValid = Right <= other.Right;
                bool bottomIsValid = Bottom <= other.Bottom;

                return leftIsValid 
                    && rightIsValid 
                    && topIsValid 
                    && bottomIsValid;
            }
        }

        static void Main(string[] args)
        {
            Rectangle firstRect = ReadRectangle();
            Rectangle secondRect = ReadRectangle();
            bool result = firstRect.IsInside(secondRect);
            Console.WriteLine(result ? "Inside" : "Not inside");
        }

        static Rectangle ReadRectangle()
        {
            double[] rectStats = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Rectangle rectangle = new Rectangle()
            {
                Left = rectStats.First(),
                Top = rectStats.Skip(1).First(),
                Width = rectStats.Skip(2).First(),
                Height = rectStats.Skip(3).First()
            };
            return rectangle;
        }
    }
}
