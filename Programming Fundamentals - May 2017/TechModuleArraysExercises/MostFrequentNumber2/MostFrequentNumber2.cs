using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber2
{
    class MostFrequentNumber2
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(arr.GroupBy(v => v).OrderByDescending(g => g.Count()).First().Key);
        }
    }
}
