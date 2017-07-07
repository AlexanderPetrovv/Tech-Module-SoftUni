using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeRadioFrequencies
{
    class DecodeRadioFrequencies
    {
        static void Main(string[] args)
        {
            string[] frequencies = Console.ReadLine().Split(' ', '.').ToArray();

            List<int> leftNums = new List<int>();
            List<int> rightNums = new List<int>();

            // Distribute numbers
            DistributeNums(frequencies, leftNums, rightNums);

            // Reverse rightNums
            ReverseNumbers(rightNums);

            // Concat leftNums and rightNums
            leftNums = ConcatLists(leftNums, rightNums);

            // Remove zeroes
            RemoveZeroes(leftNums);

            // Convert every number to its ASCII representation
            List<char> message = ConvertNumsToChars(leftNums);

            Console.WriteLine(string.Join("", message));
        }

        static List<char> ConvertNumsToChars(List<int> leftNums)
        {
            var message = new List<char>();
            foreach (var num in leftNums)
            {
                message.Add((char)num);
            }

            return message;
        }

        static void RemoveZeroes(List<int> leftNums)
        {
            for (int i = 0; i < leftNums.Count; i++)
            {
                if (leftNums[i] == 0)
                {
                    leftNums.Remove(leftNums[i]);
                    i--;
                }
            }
        }

        static List<int> ConcatLists(List<int> leftNums, List<int> rightNums)
        {
            leftNums = leftNums.Concat(rightNums).ToList();
            return leftNums;
        }

        static void ReverseNumbers(List<int> rightNums)
        {
            for (int i = 0; i < rightNums.Count / 2; i++)
            {
                int temp = rightNums[i];
                rightNums[i] = rightNums[rightNums.Count - 1 - i];
                rightNums[rightNums.Count - 1 - i] = temp;
            }
        }

        static void DistributeNums(string[] frequencies, List<int> leftNums, List<int> rightNums)
        {
            for (int i = 0; i < frequencies.Length; i += 2)
            {
                leftNums.Add(int.Parse(frequencies[i]));
                rightNums.Add(int.Parse(frequencies[i + 1]));
            }
        }
    }
}
