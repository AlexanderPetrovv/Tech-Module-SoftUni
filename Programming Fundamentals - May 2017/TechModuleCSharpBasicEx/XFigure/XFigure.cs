using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFigure
{
    class XFigure
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            // top part
            for (int i = 0; i < number / 2; i++)
            {
                Console.WriteLine("{0}x{1}x",
                    new string(' ', i),
                    new string(' ', number - 2 - 2 * i));           // formula for empty mid spaces
            }
            // mid row
            Console.WriteLine("{0}x",
                new string(' ', (number - 1) / 2));
            // bot part
            for (int i = number / 2; i > 0; i--)
            {
                Console.WriteLine("{0}x{1}x",
                    new string(' ', i - 1),
                    new string(' ', number - 2 - 2 * (i - 1)));           
            }
        }
    }
}
