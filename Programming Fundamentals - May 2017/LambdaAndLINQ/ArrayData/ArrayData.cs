using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayData
{
    class ArrayData
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            List<int> result = numbers.Where(x => x >= numbers.Average()).OrderBy(x => x).ToList();

            if (command == "Min")
            {
                int minElement = result.Min();
                Console.WriteLine(minElement);
            }
            else if (command == "Max")
            {
                int maxElement = result.Max();
                Console.WriteLine(maxElement);
            }
            else if (command == "All")
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
