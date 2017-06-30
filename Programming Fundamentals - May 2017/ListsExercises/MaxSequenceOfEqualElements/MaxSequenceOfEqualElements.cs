using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> currentMaxSeq = new List<int>();
            List<int> longestMaxSeq = new List<int>();

            currentMaxSeq.Add(nums[0]);
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    currentMaxSeq.Add(nums[i]);
                }
                else
                {
                    if (currentMaxSeq.Count > longestMaxSeq.Count)
                    {
                        // !!! longestMaxSeq = currentMaxSeq is wrong cuz lists are referent type
                        longestMaxSeq = new List<int>();
                        longestMaxSeq.AddRange(currentMaxSeq);
                    }
                    currentMaxSeq.Clear();      // Or currentMaxSeq = new List<int>();
                    currentMaxSeq.Add(nums[i]);
                }
            }

            if (currentMaxSeq.Count > longestMaxSeq.Count)
            {
                longestMaxSeq = new List<int>();
                longestMaxSeq.AddRange(currentMaxSeq);
            }

            Console.WriteLine(string.Join(" ", longestMaxSeq));
        }
    }
}
