using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestElementInArray
{
    class SmallestElementInArray
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int smallestInt = FindMinElement(input);
            Console.WriteLine(smallestInt);
        }

        static int FindMinElement(int[] input)
        {
            var smallestInt = int.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] < smallestInt)
                {
                    smallestInt = input[i];
                }
            }

            return smallestInt;
        }
    }
}
