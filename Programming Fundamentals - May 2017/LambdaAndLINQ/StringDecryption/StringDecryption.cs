using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDecryption
{
    class StringDecryption
    {
        static void Main(string[] args)
        {
            int[] skipTakeElements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int skipElements = skipTakeElements[0];
            int takeElements = skipTakeElements[1];
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> filteredArray = numbers
                .Where(x => x >= 65 && x <= 90)
                .Skip(skipElements)
                .Take(takeElements)
                //.Distinct()
                .ToList();

            foreach (var integer in filteredArray)
            {
                Console.Write((char)integer);
            }
            Console.WriteLine();

        }
    }
}
