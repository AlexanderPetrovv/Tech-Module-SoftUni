using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

/*
Create a program that counts the trailing zeroes of the factorial of a given number.
*/

namespace FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintFactorialTrailingZeroes(n);
        }

        static void PrintFactorialTrailingZeroes(int n)
        {
            BigInteger factorial = CalcFactorial(n);
            int zeroCnt = 0;
            while(factorial % 10 == 0)
            {
                zeroCnt++;
                factorial /= 10;
            }
            Console.WriteLine(zeroCnt);
        }

        static BigInteger CalcFactorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
