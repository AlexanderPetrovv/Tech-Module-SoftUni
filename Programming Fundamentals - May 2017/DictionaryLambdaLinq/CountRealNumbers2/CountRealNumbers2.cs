using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers2
{
    class CountRealNumbers2
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            var dict = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                dict[num] = 0;
            }

            foreach (var num in numbers)
            {
                dict[num]++;
            }

            foreach (var pair in dict)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
