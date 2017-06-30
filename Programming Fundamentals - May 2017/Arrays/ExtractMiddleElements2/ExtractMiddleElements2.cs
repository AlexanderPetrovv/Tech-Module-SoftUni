using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElements2
{
    class ExtractMiddleElements2
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] mid = ExtractMiddleElements(arr);
            Console.WriteLine("{ " + string.Join(", ", mid) + " }");
        }

        static int[] ExtractMiddleElements(int[] arr)
        {
            int start = arr.Length / 2 - 1;
            int end = start + 2;
            if (arr.Length == 1)
            {
                start = end = 0;
            }
            else if (arr.Length % 2 == 0)
            {
                end--;
            }

            int[] mid = new int[end - start + 1];
            int j = 0;
            for (int i = start; i <= end; i++)
            {
                mid[j] = arr[i];
                j++;
            }
            return mid;
        }
    }
}
