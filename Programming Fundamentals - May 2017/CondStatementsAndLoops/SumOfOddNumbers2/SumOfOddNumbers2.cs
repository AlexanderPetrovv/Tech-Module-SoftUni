using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers2
{
    class SumOfOddNumbers2
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var sum = 0;
            var number = 1;

            while (count > 0)
            {
                Console.WriteLine(number);
                sum += number;
                count--;
                number += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
