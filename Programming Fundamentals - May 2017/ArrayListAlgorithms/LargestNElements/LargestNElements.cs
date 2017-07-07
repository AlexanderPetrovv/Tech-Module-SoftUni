using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNElements
{
    class LargestNElements
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numbersToTake = int.Parse(Console.ReadLine());

            ReversedInsertionSort(nums);

            List<int> resultList = GetNumbers(nums, numbersToTake);
            Console.WriteLine(string.Join(" ", resultList));
        }

        static List<int> GetNumbers(int[] nums, int numbersToTake)
        {
            List<int> resultList = new List<int>();

            for (int i = 0; i < numbersToTake; i++)
            {
                resultList.Add(nums[i]);
            }
            return resultList;
        }

        static void ReversedInsertionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int j = i + 1;
                while (j > 0)
                {
                    if (nums[j] > nums[j - 1])
                    {
                        Swap(ref nums[j], ref nums[j - 1]);
                    }
                    j--;
                }
            }
        }

        static void Swap(ref int currentNum, ref int previousNum)
        {
            int temp = currentNum;
            currentNum = previousNum;
            previousNum = temp;
        }
    }
}
