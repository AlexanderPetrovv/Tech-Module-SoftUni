using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a method to extract the middle 1, 2 or 3 elements from array of n integers and print them.
- n = 1 -> 1 element
- even n -> 2 elements
- odd n -> 3 elements
Create a program that reads an array of integers (space separated values)
and prints the middle elements in the format shown in the examples.
*/

namespace ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');
            int[] numbers = new int[strArr.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(strArr[i]);
            }

            ExtractMiddleElementsFrom(numbers);
        }

        static void ExtractMiddleElementsFrom(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                Console.WriteLine($"{{ {numbers[0]} }}");
            }
            else if (numbers.Length % 2 == 1)
            {
                Console.WriteLine($"{{ {numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}, {numbers[numbers.Length / 2 + 1]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]} }}");
            }
        }
    }
}
