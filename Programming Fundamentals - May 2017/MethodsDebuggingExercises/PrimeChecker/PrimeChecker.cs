using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a Boolean method IsPrime(n) that check whether a given integer number n is prime.
*/

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long integer = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(integer));
        }

        static bool IsPrime(long integer)
        {
            if (integer == 0 || integer == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(integer); i++)
            {              
                if (integer % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
