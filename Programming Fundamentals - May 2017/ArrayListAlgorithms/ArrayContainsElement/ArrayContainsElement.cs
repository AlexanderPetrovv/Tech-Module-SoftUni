using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContainsElement
{
    class ArrayContainsElement
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numToCheck = int.Parse(Console.ReadLine());

            bool isFound = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == numToCheck)
                {
                    isFound = true;
                    break;
                }
            }

            Console.WriteLine(isFound ? "yes" : "no");
        }
    }
}
