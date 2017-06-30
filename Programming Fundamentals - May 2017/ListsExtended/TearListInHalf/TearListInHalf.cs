using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListInHalf
{
    class TearListInHalf
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> bottomList = new List<int>();
            List<int> topList = new List<int>();

            for (int i = 0; i < input.Count / 2; i++)
            {
                bottomList.Add(input[i]);       // From index 0 to mid
                topList.Add(input[i + input.Count / 2]);   // From mid to last index
            }

            for (int i = 0; i < topList.Count; i++)
            {
                int firstDigit = topList[i] / 10;
                int lastDigit = topList[i] % 10;

                int leftIndex = i * 3;
                int rigtIndex = leftIndex + 2;
                bottomList.Insert(leftIndex, firstDigit);
                bottomList.Insert(rigtIndex, lastDigit);
            }

            Console.WriteLine(string.Join(" ", bottomList));
        }
    }
}
