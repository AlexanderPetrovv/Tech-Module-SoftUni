using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers2
{
    class SumReversedNumbers2
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ').ToList();

            long sum = 0;

            foreach (string number in numbers)
            {
                char[] arr = number.ToCharArray();
                arr = arr.Reverse().ToArray();
                long num = int.Parse(new string(arr));
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
