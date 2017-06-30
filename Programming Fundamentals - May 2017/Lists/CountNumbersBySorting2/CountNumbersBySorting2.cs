using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbersBySorting2
{
    class CountNumbersBySorting2
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            nums.Sort();

            int cnt = 1;
            for (int i = 0; i < nums.Count; i++)
            {
                int currentNum = nums[i];
                if ((i < nums.Count - 1 && currentNum != nums[i + 1]) || (i == nums.Count - 1))
                {
                    Console.WriteLine($"{currentNum} -> {cnt}");
                    cnt = 0;
                }
                cnt++;
            }
        }
    }
}
