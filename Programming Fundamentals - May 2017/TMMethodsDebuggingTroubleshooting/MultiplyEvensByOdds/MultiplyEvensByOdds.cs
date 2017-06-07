using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create a program that reads an integer number and multiplies the sum of all its even digits by the sum of all its odd digits.
*/

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumEvens = GetSumOfEvenDigits(number);
            int sumOdds = GetSumOfOddDigits(number);
            return sumEvens * sumOdds;
        }

        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }
                number /= 10;
            }
            return oddSum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
                number /= 10;
            }
            return evenSum;
        }
    }
}
