using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program that can calculate:
- the length of the face diagonals
- the length of the space diagonals
- volume and surface area of a cube (http://www.mathopenref.com/cube.html) by a given side.
On the first line you will get the side of the cube.
On the second line is given the parameter (face, space, volume or area).
Output should be rounded to the second digit after the decimal point.

*/

namespace CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            PrintResultMessage(cubeSide, parameter);
        }

        private static void PrintResultMessage(double cubeSide, string parameter)
        {
            double result = 0;
            switch (parameter)
            {
                case "face":
                    result = CalcLengthOfCubeFaceDiagonals(cubeSide);
                    break;
                case "space":
                    result = CalcLegthOfCubeSpaceDiagonals(cubeSide);
                    break;
                case "volume":
                    result = CalcCubeVolume(cubeSide);
                    break;
                case "area":
                    result = CalcCubeArea(cubeSide);
                    break;
            }

            Console.WriteLine($"{result:f2}");
        }

        static double CalcCubeArea(double cubeSide)
        {
            double area = 6 * Math.Pow(cubeSide, 2);
            return area;
        }

        static double CalcCubeVolume(double cubeSide)
        {
            double volume = Math.Pow(cubeSide, 3);
            return volume;
        }

        static double CalcLegthOfCubeSpaceDiagonals(double cubeSide)
        {
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
            return spaceDiagonal;
        }

        static double CalcLengthOfCubeFaceDiagonals(double cubeSide)
        {
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
            return faceDiagonal;
        }
    }
}
