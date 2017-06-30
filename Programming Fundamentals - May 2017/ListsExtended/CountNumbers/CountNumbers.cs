using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Sort();
            int[] count = new int[numbers.Max() + 1];
            foreach (var num in numbers)
            {
                count[num]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if(count[i] > 0)
                {
                    Console.WriteLine($"{i} -> {count[i]}");
                }
            }

            //var dict = new SortedDictionary<int, int>();
            //foreach (var num in numbers)
            //{
            //    if (!dict.ContainsKey(num))
            //    {
            //        dict[num] = 0;
            //    }
            //    dict[num]++;
            //}

            //foreach (var num in dict)
            //{ 
            //    Console.WriteLine($"{num.Key} -> {num.Value}");
            //}
        }
    }
}
