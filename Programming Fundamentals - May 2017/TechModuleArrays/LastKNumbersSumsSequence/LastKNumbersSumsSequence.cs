using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Enter two integers n and k. Generate and print the following sequence of n elements:
- The first element is: 1
- All other elements = sum of the previous k elements (if less than k are available, sum all of them)
- Example: n = 9, k = 5 -> 120 = 4 + 8 + 16 + 31 + 61
*/

namespace LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] seq = new long[n];
            seq[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int j = i - 1; j >= 0 && j>= i - k; j--)
                {
                    sum += seq[j];
                }
                seq[i] = sum;
            }
            Console.WriteLine(string.Join(" ", seq));
        }
    }
}
