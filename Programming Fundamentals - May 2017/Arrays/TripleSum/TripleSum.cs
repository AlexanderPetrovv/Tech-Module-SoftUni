using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program to read an array of integers and find all triples of elements a, b and c,
such that a + b == c (where a stays to the left from b).
Print “No” if no such triples exist.
*/

namespace TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(' ');

            int[] numbers = new int[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                numbers[i] = int.Parse(items[i]);
            }

            int cnt = 0;
            for (int a = 0; a < numbers.Length - 1; a++)
            {
                for (int b = a + 1; b < numbers.Length; b++)
                {
                    int sum = numbers[a] + numbers[b];
                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{numbers[a]} + {numbers[b]} == {sum}");
                        cnt++;
                    }
                }
            }

            if (cnt == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
