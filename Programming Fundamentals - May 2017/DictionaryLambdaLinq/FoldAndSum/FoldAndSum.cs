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
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int[] leftPart = numbers.Take(k).Reverse().ToArray();
            int[] rightPart = numbers.Reverse().Take(k).ToArray();
            int[] topRow = leftPart.Concat(rightPart).ToArray();
            int[] bottomRow = numbers.Skip(k).Take(2 * k).ToArray();

            //var sumArr = topRow.Select((num, index) => num + bottomRow[index]);
            var sumArr = topRow.Zip(bottomRow, (a, b) => (a + b));
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
