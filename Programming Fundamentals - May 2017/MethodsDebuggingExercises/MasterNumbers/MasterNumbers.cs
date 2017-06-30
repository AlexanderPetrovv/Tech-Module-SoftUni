using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
A master number is an integer that holds the following properties:
- Is symmetric (palindrome), e.g. 5, 77, 282, 14341, 9553559.
- Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173.
- Holds at least one even digit, e.g. 232, 707, 6886, 87578.
Write a program to print all master numbers in the range [1…n].
*/

namespace MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int num = 1; num <= endNumber; num++)
            {
                PrintMasterNumbers(num);      
            }
        }

        static void PrintMasterNumbers(int num)
        {
            if (IsPalindrome(num) && CheckIfDigitSumDividesBySeven(num) && ContainsEvenDigit(num))
            {
                Console.WriteLine(num);
            }
        }

        static bool ContainsEvenDigit(int num)
        {
            bool isEven = false;
            while (num > 0)
            {
                int digit = num % 10;               
                num = num / 10;
                if (digit % 2 == 0)
                {
                    isEven = true;
                    break;
                }
            }
            return isEven;
        }

        static bool CheckIfDigitSumDividesBySeven(int num)
        {
            int digitSum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                digitSum += digit;
                num = num / 10;
            }

            return digitSum % 7 == 0 ? true : false;
        }

        static bool IsPalindrome(int num)
        {
            int temp = num;
            int reverseNum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                reverseNum = reverseNum * 10 + digit;
                num /= 10;
            }

            return reverseNum == temp ? true : false;
        }
    }
}
