using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder2
{
    class NumbersInReversedOrder2
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal numInReverse = ReverseNumberDigits(number);
            Console.WriteLine(numInReverse);
        }

        static decimal ReverseNumberDigits(decimal number)
        {
            string numToString = new string(number.ToString().Reverse().ToArray());
            return decimal.Parse(numToString);
        }
    }
}
