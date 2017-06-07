using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create a method for printing triangles as shown below:
*/

namespace PrintTriangle
{
    class PrintTriangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangleWithGivenNumber(n);
        }

        static void PrintTriangleWithGivenNumber(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
