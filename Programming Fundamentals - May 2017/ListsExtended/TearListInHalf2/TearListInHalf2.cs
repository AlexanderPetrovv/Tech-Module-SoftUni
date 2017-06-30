using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListInHalf2
{
    class TearListInHalf2
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> bottomList = input.Take(input.Count / 2).ToList();
            List<int> topList = input.Skip(input.Count / 2).ToList();

            List<int> result = new List<int>();
            for (int i = 0; i < bottomList.Count; i++)
            {
                result.Add(topList[i] / 10);
                result.Add(bottomList[i]);
                result.Add(topList[i] % 10);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
