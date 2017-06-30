using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabAndGo2
{
    class GrabAndGo2
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            long sum = 0;
            bool isFound = false;
            for (int i = arr.Length - 1; i > -1; i--)
            {
                if (isFound)
                {
                    sum += arr[i];
                }
                else
                {
                    if (arr[i] == num)
                        isFound = true;
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
