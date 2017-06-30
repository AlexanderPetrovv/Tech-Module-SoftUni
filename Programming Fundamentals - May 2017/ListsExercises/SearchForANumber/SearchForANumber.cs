using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> conditionNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int numberOfElementsToTake = conditionNums[0];
            int numberOfElementsToDelete = conditionNums[1];
            int searchNum = conditionNums[2];

            List<int> result = new List<int>();
            for (int i = 0; i < numberOfElementsToTake; i++)
            {
                result.Add(nums[i]);
            }

            result.RemoveRange(0, numberOfElementsToDelete);

            Console.WriteLine(result.Contains(searchNum) ? "YES!" : "NO!");
        }
    }
}
