using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int len = 1;
            int index = 0;
            int bestLen = 0;
            int bestIndex = 0;

            for (int i = 1; i <= sequence.Length - 1; i++)
            {
                if (sequence[i] > sequence[i - 1])
                {
                    len++;

                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestIndex = index;
                    }
                }
                else
                {
                    index = i;
                    len = 1;
                }
            }

            for (int j = bestIndex; j < bestIndex + bestLen; j++)
            {
                Console.Write(sequence[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
