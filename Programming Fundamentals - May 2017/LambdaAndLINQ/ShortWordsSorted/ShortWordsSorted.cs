using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] delimiters = ".,:;()[]\"\'\\/!? ".ToCharArray();
            string[] text = Console.ReadLine()
                .ToLower()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(word => word.Length < 5)
                .OrderBy(word => word)
                .ToArray();

            Console.WriteLine(string.Join(", ", text));

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}
