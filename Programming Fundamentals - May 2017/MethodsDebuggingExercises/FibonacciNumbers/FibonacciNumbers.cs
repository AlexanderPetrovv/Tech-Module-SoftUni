using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Define a method Fib(n) that calculates the nth Fibonacci number.
*/

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long nthFibonacciNum = CalculateFibonacciNumber(n);
            Console.WriteLine(nthFibonacciNum);
        }

        static long CalculateFibonacciNumber(int n)
        {
            long currentSum = 1;
            long previousSum = 0;
            for (int i = 0; i < n; i++)
            {
                long temp = previousSum;
                previousSum = currentSum;
                currentSum = temp + currentSum;
            }
            return currentSum;
        }
    }
}
