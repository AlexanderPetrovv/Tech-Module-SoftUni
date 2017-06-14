using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStatistics
{
    class ArrayStatistics
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int minNum = GetMinimumNumber(integers);
            int maxNum = GetMaximumNumber(integers);
            int sum = GetSumOfNumbers(integers);
            double average = GetAverageValue(integers);
            Console.WriteLine($"Min = {minNum}\r\nMax = {maxNum}\r\nSum = {sum}\r\nAverage = {average}");
        }

        static int GetMinimumNumber(int[] integers)
        {
            int minNum = int.MaxValue;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] < minNum)
                {
                    minNum = integers[i];
                }
            }
            return minNum;
        }

        static int GetMaximumNumber(int[] integers)
        {
            int maxNum = int.MinValue;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] > maxNum)
                {
                    maxNum = integers[i];
                }
            }
            return maxNum;
        }

        static int GetSumOfNumbers(int[] integers)
        {
            int sum = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                sum += integers[i];
            }
            return sum;
        }

        static double GetAverageValue(int[] integers)
        {
            double averageValue = 0.0;
            averageValue = (double)GetSumOfNumbers(integers) / integers.Length;
            return averageValue;
        }
    }
}
