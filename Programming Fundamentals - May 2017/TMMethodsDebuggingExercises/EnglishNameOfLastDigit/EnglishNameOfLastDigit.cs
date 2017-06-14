using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a method that returns the English name of the last digit of a given number.
Write a program that reads an integer and prints the returned value from this method.
*/

namespace EnglishNameOfLastDigit
{
    class EnglishNameOfLastDigit
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigitName(num));
        }

        static string GetLastDigitName(long num)
        {
            long lastDigit = Math.Abs(num % 10);
            string lastDigitName = String.Empty;
            switch (lastDigit)
            {
                case 0: lastDigitName = "zero"; break;
                case 1: lastDigitName = "one"; break;
                case 2: lastDigitName = "two"; break;
                case 3: lastDigitName = "three"; break;
                case 4: lastDigitName = "four"; break;
                case 5: lastDigitName = "five"; break;
                case 6: lastDigitName = "six"; break;
                case 7: lastDigitName = "seven"; break;
                case 8: lastDigitName = "eight"; break;
                case 9: lastDigitName = "nine"; break;
            }
            return lastDigitName;
        }
    }
}
