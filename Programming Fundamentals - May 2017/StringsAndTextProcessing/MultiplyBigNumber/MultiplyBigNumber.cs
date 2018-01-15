using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            /*You are given two lines – the first one can be a really big number (0 to 10^50). 
            The second one will be a single digit number (0 to 9). You must display the product of these numbers.
            Note: do not use the BigInteger or BigDecimal classes for solving this problem.*/


            string number = Console.ReadLine().TrimStart(new[] { '0' });
            int multiplier = int.Parse(Console.ReadLine());

            var result = MultiplyNumbers(number, multiplier);
            Console.WriteLine(result);
        }

        static string MultiplyNumbers(string number, int multiplier)
        {
            if (number == "0" || multiplier == 0)
            {
                return "0";
            }
            StringBuilder result = new StringBuilder();
            int carry = 0;
            int digitToAppend;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                var currntDigit = int.Parse(number[i].ToString());

                var multiplication = currntDigit * multiplier + carry;

                digitToAppend = multiplication % 10;
                carry = multiplication / 10;

                result.Insert(0, digitToAppend);

                if (i == 0 && carry != 0)
                {
                    result.Insert(0, carry);
                }           
            }
            return result.ToString();
        }
    }
}
