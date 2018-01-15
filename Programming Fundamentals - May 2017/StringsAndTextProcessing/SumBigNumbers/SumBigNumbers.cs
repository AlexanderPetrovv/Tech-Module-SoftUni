using System;
using System.Linq;
using System.Text;

namespace SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            //Note: do not use the BigInteger or BigDecimal classes for solving this problem.
            string firstNum = Console.ReadLine().TrimStart(new[] { '0' });
            string secondNum = Console.ReadLine().TrimStart(new[] { '0' });

            var result = SumNumbers(firstNum, secondNum);
            Console.WriteLine(result.TrimStart('0'));
        }

        static string SumNumbers(string firstNum, string secondNum)
        {
            firstNum = new string(firstNum.Reverse().ToArray());
            secondNum = new string(secondNum.Reverse().ToArray());
            StringBuilder result = new StringBuilder();

            int maxLength = Math.Max(firstNum.Length, secondNum.Length);
            int carry = 0;
            int digitToAdd = 0;
            for (int i = 0; i < maxLength; i++)
            {
                var firstNumCurrentDigit = GetDigit(firstNum, i);
                var secondNumCurrentDigit = GetDigit(secondNum, i);

                var digitSum = firstNumCurrentDigit + secondNumCurrentDigit + carry;
                carry = digitSum / 10;
                digitToAdd = digitSum % 10;
                result.Insert(0, digitToAdd);
                if (i == maxLength - 1)
                {
                    result.Insert(0, carry);
                }
                
            }
            return result.ToString();
        }

        static int GetDigit(string number, int index)
        {
            if (index < number.Length)
            {
                return int.Parse(number[index].ToString());
            }
            else
            {
                return 0;
            }
        }
    }
}
