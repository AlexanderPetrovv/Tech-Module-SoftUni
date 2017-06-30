using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            List<long> elements = new List<long>();
            for (int i = 0; i < numbers.Count; i++)
            {
                long num = numbers[i];
                long reversedNum = 0;
                while (num > 0)
                {
                    long digit = num % 10;
                    reversedNum = reversedNum * 10 + digit;
                    num /= 10;
                }
                elements.Add(reversedNum);
            }
            long sum = elements.Sum();
            Console.WriteLine(sum);
        }
    }
}
