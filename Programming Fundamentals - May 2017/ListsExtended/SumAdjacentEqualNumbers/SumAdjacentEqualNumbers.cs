using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                decimal currentNum = input[i];
                decimal nextNum = input[i + 1];
                if (currentNum == nextNum)
                {
                    input[i] *= 2;
                    input.Remove(input[i + 1]);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
