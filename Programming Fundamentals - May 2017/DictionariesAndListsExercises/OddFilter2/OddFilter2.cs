using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter2
{
    class OddFilter2
    {
        static void Main(string[] args)
        {
            int[] initialNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] evenNums = initialNums.Where(x => x % 2 == 0).ToArray();

            int[] finalNums = evenNums.Select(x => x > evenNums.Average() ? ++x : --x).ToArray();

            Console.WriteLine(string.Join(" ", finalNums));
        }
    }
}
