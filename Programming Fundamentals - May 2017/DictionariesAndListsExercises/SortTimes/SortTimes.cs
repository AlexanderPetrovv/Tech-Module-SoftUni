using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTimes
{
    class SortTimes
    {
        static void Main(string[] args)
        {
            List<string> times = Console.ReadLine().Split(' ').OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ", times));
        }
    }
}
