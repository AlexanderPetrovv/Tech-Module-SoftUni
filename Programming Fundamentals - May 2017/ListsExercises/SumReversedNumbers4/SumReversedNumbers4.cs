using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers4
{
    class SumReversedNumbers4
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];
                string currentNumStr = currentNum.ToString();
                char[] reversedNumArray = currentNumStr.Reverse().ToArray();
                string reversedNum = new string(reversedNumArray);

                numbers[i] = int.Parse(reversedNum);
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
