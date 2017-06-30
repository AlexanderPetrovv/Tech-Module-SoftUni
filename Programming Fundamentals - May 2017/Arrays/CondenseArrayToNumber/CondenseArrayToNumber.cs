using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program to read an array of integers.
Condense them by summing adjacent couples of elements until a single integer is obtained.
For example, if we have 3 elements {2, 10, 3},
we sum the first two and the second two elements and obtain {2+10, 10+3} = {12, 13},
then we sum again all adjacent elements and obtain {12+13} = {25}.
*/

namespace CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (array.Length > 1)
            {
                int[] newArray = new int[array.Length - 1];

                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = array[i] + array[i + 1];
                }
                array = newArray;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
