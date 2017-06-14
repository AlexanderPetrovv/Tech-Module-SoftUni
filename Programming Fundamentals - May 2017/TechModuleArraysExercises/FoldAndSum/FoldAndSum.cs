using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = numbers.Length / 4;
            int[] leftArray = new int[k];
            int[] rightArray = new int[k];

            for (int i = 0; i < k; i++)
            {
                leftArray[i] = numbers[i];
                rightArray[i] = numbers[3 * k + i];
            }

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);
            

            int[] midArray = new int[2 * k];
            for (int i = 0; i < 2 * k; i++)
            {
                midArray[i] = numbers[k + i];
            }

            for (int i = 0; i < k; i++)
            {
                midArray[i] += leftArray[i];
                midArray[k + i] += rightArray[i];
            }

            Console.WriteLine(string.Join(" ", midArray));
        }
    }
}
