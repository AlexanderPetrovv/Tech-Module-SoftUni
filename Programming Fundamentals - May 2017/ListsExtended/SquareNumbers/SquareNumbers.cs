using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> squareNums = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                bool isSquareRoot = Math.Sqrt(nums[i]) == (int)Math.Sqrt(nums[i]);
                if (isSquareRoot)
                {
                    squareNums.Add(nums[i]);
                }
            }
            squareNums.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
