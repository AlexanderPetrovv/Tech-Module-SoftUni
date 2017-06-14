using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabAndGo3
{
    class GrabAndGo3
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numToCheck = int.Parse(Console.ReadLine());

            int index = 0;
            bool isFound = false;
            for (int i = arr.Length - 1; i >= 0; i++)
            {
                if (arr[i] == numToCheck)
                {
                    index = i;
                    isFound = true;
                    break;
                }
            }

            long sum = 0;
            if (isFound)
            {
                for (int i = 0; i < index; i++)
                {
                    sum += arr[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
