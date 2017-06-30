using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 0;

            for (int i = 1; i <= sequence.Length - 1; i++)
            {
                if (sequence[i] == sequence[i - 1])
                {
                    len++;

                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                }
                else
                {
                    start = i;
                    len = 1;
                }

            }

            for (int j = bestStart; j < bestStart + bestLen; j++)
            {
                Console.Write(sequence[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
