using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabAndGo
{
    class GrabAndGo
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            long sum = 0;
            bool isFound = false;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == num)
                {
                    isFound = true;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        sum += arr[j];
                    }
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
