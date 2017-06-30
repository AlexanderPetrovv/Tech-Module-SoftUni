using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Counting occurrences by sorting 

namespace CountNumbersBySorting
{
    class CountNumbersBySorting
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            nums.Sort();

            int index = 0;
            while (index < nums.Count)
            {
                int currentNum = nums[index];
                int numCnt = 1;

                while (index + numCnt < nums.Count && nums[index + numCnt] == currentNum)
                {
                    numCnt++;
                }
                index = index + numCnt;
                Console.WriteLine($"{currentNum} -> {numCnt}");
            }

        }
    }
}
