using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int targetNum = int.Parse(Console.ReadLine());

            int linearIterations = LinearSearchAlgo(numbers, targetNum);
            
            Array.Sort(numbers);
            int binaryIterations = BinarySearchAlgo(numbers, targetNum);

            if (numbers.Contains(targetNum))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine($"Linear search made {linearIterations} iterations");
            Console.WriteLine($"Binary search made {binaryIterations} iterations");
        }

        static int LinearSearchAlgo(int[] numbers, int targetNum)
        {
            int iterations = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                iterations++;
                if (numbers[i] == targetNum)
                {
                    break;
                }
            }
            return iterations;
        }

        private static int BinarySearchAlgo(int[] numbers, int targetNum)
        {
            int iterations = 0;
            int left = 0;
            int right = numbers.Length - 1;
            bool isFound = false;
            while (!isFound)
            {
                if (right < left)
                {
                    break;
                }

                iterations++;
                int mid = left + (right - left) / 2;

                if (numbers[mid] < targetNum)
                {
                    left = mid + 1;
                }
                else if (numbers[mid] > targetNum)
                {
                    right = mid - 1;
                }
                else if (numbers[mid] == targetNum)
                {
                    isFound = true;
                }
            }
            return iterations;
        }
    }
}
