using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a method that calculates all prime numbers in given range and returns them as list of integers.
Write a method to print a list of integers.
Write a program that enters two integer numbers(each at a separate line) and prints all primes in their range, separated by a comma.
*/

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            var primes = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(string.Join(", ", primes));
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();

            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                if (IsPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
            }
            return primes;
        }

        static bool IsPrime(int currentNum)
        {
            if (currentNum == 0 || currentNum == 1)
            {
                return false;
            }
            var maxNum = Math.Sqrt(currentNum);
            for (int i = 2; i <= maxNum; i++)
            {
                if (currentNum % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
