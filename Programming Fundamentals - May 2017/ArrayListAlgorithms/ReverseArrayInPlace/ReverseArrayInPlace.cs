using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayInPlace
{
    class ReverseArrayInPlace
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            ReverseArray(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void ReverseArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                var temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }
        }
    }
}
