using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Could use Fenwick tree to solve.

namespace LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] len = new int[numbers.Count];
            int[] prev = new int[numbers.Count];

            int maxLen = 0;
            int lastIndex = -1;

            for (int i = 0; i < numbers.Count; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && len[j] + 1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }

                if (len[i] > maxLen)
                {
                    maxLen = len[i];
                    lastIndex = i;
                }
            }

            List<int> lis = new List<int>();

            while (lastIndex != -1)
            {
                lis.Add(numbers[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            lis.Reverse();

            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
