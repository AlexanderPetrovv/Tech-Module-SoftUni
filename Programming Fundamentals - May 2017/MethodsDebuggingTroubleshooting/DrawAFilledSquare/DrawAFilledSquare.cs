using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Draw at the console a filled square of size n like in the example:
*/

namespace DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderFooterLine(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintHeaderFooterLine(n);
        }

        static void PrintMiddleRow(int number)
        {
            Console.Write("-");
            for (int i = 1; i < number; i++)
            {
                Console.Write("\\/");

            }
            Console.WriteLine("-");
        }

        static void PrintHeaderFooterLine(int number)
        {
            Console.WriteLine(new string ('-', 2 * number));
        }
    }
}
