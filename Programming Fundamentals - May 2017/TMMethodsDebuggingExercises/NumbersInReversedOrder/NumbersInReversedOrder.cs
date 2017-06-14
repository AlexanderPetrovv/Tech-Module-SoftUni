using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a method that prints the digits of a given decimal number in a reversed order.
*/

namespace NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal reversedNumber = ReverseNumberDigits(number);
            Console.WriteLine(reversedNumber);
        }

        static decimal ReverseNumberDigits(decimal number)
        {
            string numToString = number.ToString();
            string result = String.Empty;
            for (int i = numToString.Length - 1; i >= 0; i--)
            {
                result += numToString[i];
            }
            return decimal.Parse(result);
        }
    }
}
