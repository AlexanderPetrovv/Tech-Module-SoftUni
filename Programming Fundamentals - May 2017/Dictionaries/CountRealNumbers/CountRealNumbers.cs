using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numbers.ContainsKey(nums[i]))
                {
                    numbers.Add(nums[i], 0);
                }
                numbers[nums[i]]++;
            }

            foreach (KeyValuePair<double, int> num in numbers)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
