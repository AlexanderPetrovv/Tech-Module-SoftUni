using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a program, which checks if a number is an integer or a floating-point number and prints either
 “floating-point” or “integer”, depending on the case. You will only receive numbers.
*/

namespace NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long number;
            bool isFloatingNum = long.TryParse(input, out number);

            if (isFloatingNum)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }

        }
    }
}
