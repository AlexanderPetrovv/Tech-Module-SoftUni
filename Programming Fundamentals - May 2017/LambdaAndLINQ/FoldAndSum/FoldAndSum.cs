using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] initialNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = initialNumbers.Length / 4;

            int[] leftPart = initialNumbers.Take(k).Reverse().ToArray();
            int[] rightPart = initialNumbers.Skip(3 * k).Take(k).Reverse().ToArray();

            int[] midPart = initialNumbers.Skip(k).Take(2 * k).ToArray();

            leftPart = leftPart.Concat(rightPart).ToArray();

            //var sum = leftPart.Select((x, i) => x + middlePart[i]);
            var sum = leftPart.Zip(midPart, (a, b) => (a + b));

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
